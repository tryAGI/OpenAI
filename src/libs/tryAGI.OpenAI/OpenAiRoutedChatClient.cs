using System.Net;
using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI;

/// <summary>
/// Alias-aware <see cref="Meai.IChatClient"/> that routes requests across multiple <see cref="OpenAiClient"/> instances.
/// </summary>
public sealed class OpenAiRoutedChatClient : Meai.IChatClient, IDisposable
{
    private readonly IReadOnlyList<OpenAiRoutedProvider> _providers;
    private readonly string _defaultAlias;
    private readonly TimeProvider _timeProvider;

    internal OpenAiRoutedChatClient(
        IReadOnlyList<OpenAiRoutedProvider> providers,
        string defaultAlias,
        TimeProvider timeProvider)
    {
        _providers = providers;
        _defaultAlias = defaultAlias;
        _timeProvider = timeProvider;
    }

    /// <summary>
    /// Returns the current routing and cooldown status for every registered provider.
    /// </summary>
    public IReadOnlyList<OpenAiRoutedProviderStatus> GetProviderStatuses()
        => _providers.Select(static provider => provider.State.GetStatus(provider.ProviderId)).ToArray();

    object? Meai.IChatClient.GetService(Type serviceType, object? serviceKey)
    {
        if (serviceKey is not null)
        {
            return null;
        }

        if (serviceType == typeof(Meai.IChatClient) || serviceType.IsInstanceOfType(this))
        {
            return this;
        }

        return null;
    }

    async Task<Meai.ChatResponse> Meai.IChatClient.GetResponseAsync(
        IEnumerable<Meai.ChatMessage> chatMessages,
        Meai.ChatOptions? options,
        CancellationToken cancellationToken)
    {
        var resolvedRequest = ResolveCandidates(options);
        Exception? lastException = null;
        var attempted = new List<string>();
        var now = _timeProvider.GetUtcNow();

        foreach (var candidate in resolvedRequest.Candidates)
        {
            if (candidate.Provider.State.IsCoolingDown(now))
            {
                continue;
            }

            attempted.Add($"{candidate.Provider.ProviderId}:{candidate.Model.ModelId}");

            try
            {
                var routeOptions = CloneOptionsWithModel(options, candidate.Model.ModelId);
                Meai.IChatClient chatClient = candidate.Provider.Client;
                return await chatClient.GetResponseAsync(chatMessages, routeOptions, cancellationToken).ConfigureAwait(false);
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                var timeoutException = new TimeoutException($"Provider '{candidate.Provider.ProviderId}' timed out.");
                candidate.Provider.State.ObserveException(timeoutException, now);
                lastException = timeoutException;
            }
            catch (Exception ex) when (ShouldFallback(ex, resolvedRequest.RequestedModelId, candidate))
            {
                candidate.Provider.State.ObserveException(ex, now);
                lastException = ex;
            }
        }

        if (lastException is not null)
        {
            throw lastException;
        }

        throw CreateNoAvailableProviderException(resolvedRequest.RequestedModelId, attempted);
    }

    async IAsyncEnumerable<Meai.ChatResponseUpdate> Meai.IChatClient.GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> chatMessages,
        Meai.ChatOptions? options,
        [System.Runtime.CompilerServices.EnumeratorCancellation] CancellationToken cancellationToken)
    {
        var resolvedRequest = ResolveCandidates(options, requireStreaming: true);
        Exception? lastException = null;
        var attempted = new List<string>();
        var now = _timeProvider.GetUtcNow();

        foreach (var candidate in resolvedRequest.Candidates)
        {
            if (candidate.Provider.State.IsCoolingDown(now))
            {
                continue;
            }

            attempted.Add($"{candidate.Provider.ProviderId}:{candidate.Model.ModelId}");

            var yieldedAny = false;

            IAsyncEnumerable<Meai.ChatResponseUpdate>? updates = null;
            try
            {
                var routeOptions = CloneOptionsWithModel(options, candidate.Model.ModelId);
                Meai.IChatClient chatClient = candidate.Provider.Client;
                updates = chatClient.GetStreamingResponseAsync(chatMessages, routeOptions, cancellationToken);
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested && !yieldedAny)
            {
                var timeoutException = new TimeoutException($"Provider '{candidate.Provider.ProviderId}' timed out.");
                candidate.Provider.State.ObserveException(timeoutException, now);
                lastException = timeoutException;
            }
            catch (Exception ex) when (!yieldedAny && ShouldFallback(ex, resolvedRequest.RequestedModelId, candidate))
            {
                candidate.Provider.State.ObserveException(ex, now);
                lastException = ex;
                continue;
            }

            if (updates is null)
            {
                continue;
            }

            var enumerator = updates.GetAsyncEnumerator(cancellationToken);
            await using var _ = enumerator.ConfigureAwait(false);

            try
            {
                if (!await enumerator.MoveNextAsync().ConfigureAwait(false))
                {
                    yield break;
                }
            }
            catch (TaskCanceledException) when (!cancellationToken.IsCancellationRequested)
            {
                var timeoutException = new TimeoutException($"Provider '{candidate.Provider.ProviderId}' timed out.");
                candidate.Provider.State.ObserveException(timeoutException, now);
                lastException = timeoutException;
                continue;
            }
            catch (Exception ex) when (ShouldFallback(ex, resolvedRequest.RequestedModelId, candidate))
            {
                candidate.Provider.State.ObserveException(ex, now);
                lastException = ex;
                continue;
            }

            yieldedAny = true;
            yield return enumerator.Current;

            while (await enumerator.MoveNextAsync().ConfigureAwait(false))
            {
                yield return enumerator.Current;
            }

            yield break;
        }

        if (lastException is not null)
        {
            throw lastException;
        }

        throw CreateNoAvailableProviderException(resolvedRequest.RequestedModelId, attempted);
    }

    /// <inheritdoc />
    public void Dispose()
    {
        foreach (var provider in _providers)
        {
            provider.Dispose();
        }
    }

    private OpenAiResolvedRequest ResolveCandidates(Meai.ChatOptions? options, bool requireStreaming = false)
    {
        var requestedModelId = string.IsNullOrWhiteSpace(options?.ModelId)
            ? _defaultAlias
            : options!.ModelId!;

        var requestedIds = GetRequestedIds(requestedModelId);
        var requiresTools = options?.Tools is { Count: > 0 };
        var requiresStructuredOutputs = options?.ResponseFormat is Meai.ChatResponseFormatJson;
        var resolved = new List<OpenAiRouteCandidate>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var requestedId in requestedIds)
        {
            foreach (var provider in _providers)
            {
                foreach (var model in provider.Models)
                {
                    var isExactMatch = string.Equals(model.ModelId, requestedId, StringComparison.OrdinalIgnoreCase);
                    var isAliasMatch = !isExactMatch && model.Aliases.Contains(requestedId);
                    if (!isExactMatch && !isAliasMatch)
                    {
                        continue;
                    }

                    if (requiresTools && !model.SupportsToolCalls)
                    {
                        continue;
                    }

                    if (requiresStructuredOutputs && !model.SupportsStructuredOutputs)
                    {
                        continue;
                    }

                    if (requireStreaming && !model.SupportsStreaming)
                    {
                        continue;
                    }

                    var key = $"{provider.ProviderId}:{model.ModelId}";
                    if (!seen.Add(key))
                    {
                        continue;
                    }

                    resolved.Add(new OpenAiRouteCandidate(provider, model, isExactMatch, requestedId));
                }
            }
        }

        if (resolved.Count == 0)
        {
            throw new InvalidOperationException(
                $"No routed models matched '{requestedModelId}'. Register an exact model id or alias in {nameof(OpenAiRoutedChatClientBuilder)}.");
        }

        resolved.Sort(OpenAiRouteCandidateComparer.Instance);
        return new OpenAiResolvedRequest(requestedModelId, resolved);
    }

    private static Meai.ChatOptions CloneOptionsWithModel(Meai.ChatOptions? options, string modelId)
    {
        var clone = options?.Clone() ?? new Meai.ChatOptions();
        clone.ModelId = modelId;
        return clone;
    }

    private static bool ShouldFallback(Exception exception, string requestedModelId, OpenAiRouteCandidate candidate)
    {
        if (exception is ApiException apiException)
        {
            if (apiException.StatusCode == HttpStatusCode.TooManyRequests ||
                apiException.StatusCode == HttpStatusCode.RequestTimeout ||
                (int)apiException.StatusCode >= 500)
            {
                return true;
            }

            var isAliasRequest = !string.Equals(requestedModelId, candidate.Model.ModelId, StringComparison.OrdinalIgnoreCase);
            return isAliasRequest &&
                   (apiException.StatusCode == HttpStatusCode.BadRequest ||
                    apiException.StatusCode == HttpStatusCode.NotFound ||
                    apiException.StatusCode == HttpStatusCode.Conflict);
        }

        return exception is HttpRequestException or TimeoutException;
    }

    private static List<string> GetRequestedIds(string requestedModelId)
    {
        var requestedIds = new List<string> { requestedModelId };
        if (string.Equals(requestedModelId, OpenAiModelAliases.Smart, StringComparison.OrdinalIgnoreCase))
        {
            requestedIds.Add(OpenAiModelAliases.SmartAny);
        }

        return requestedIds;
    }

    private InvalidOperationException CreateNoAvailableProviderException(string requestedModelId, List<string> attempted)
    {
        var providerStatuses = string.Join(
            ", ",
            GetProviderStatuses().Select(
                static status => status.CooldownUntil is { } cooldownUntil
                    ? $"{status.ProviderId}=cooldown-until:{cooldownUntil:O}"
                    : $"{status.ProviderId}=ready"));

        var attempts = attempted.Count > 0
            ? string.Join(", ", attempted)
            : "none";

        return new InvalidOperationException(
            $"No provider is currently available for '{requestedModelId}'. Attempts: {attempts}. Provider states: {providerStatuses}.");
    }
}

/// <summary>
/// Snapshot of one provider's routed health and rate-limit state.
/// </summary>
public sealed class OpenAiRoutedProviderStatus
{
    internal OpenAiRoutedProviderStatus(
        string providerId,
        DateTimeOffset? cooldownUntil,
        OpenAiRateLimitSnapshot? rateLimitSnapshot,
        string? lastError)
    {
        ProviderId = providerId;
        CooldownUntil = cooldownUntil;
        RateLimitSnapshot = rateLimitSnapshot;
        LastError = lastError;
    }

    /// <summary>
    /// Gets the provider id.
    /// </summary>
    public string ProviderId { get; }

    /// <summary>
    /// Gets the current provider cooldown end time, if any.
    /// </summary>
    public DateTimeOffset? CooldownUntil { get; }

    /// <summary>
    /// Gets the last parsed rate-limit snapshot, if any.
    /// </summary>
    public OpenAiRateLimitSnapshot? RateLimitSnapshot { get; }

    /// <summary>
    /// Gets the last recorded provider error message, if any.
    /// </summary>
    public string? LastError { get; }
}

internal sealed class OpenAiResolvedRequest
{
    public OpenAiResolvedRequest(string requestedModelId, IReadOnlyList<OpenAiRouteCandidate> candidates)
    {
        RequestedModelId = requestedModelId;
        Candidates = candidates;
    }

    public string RequestedModelId { get; }
    public IReadOnlyList<OpenAiRouteCandidate> Candidates { get; }
}

internal sealed class OpenAiRouteCandidate
{
    public OpenAiRouteCandidate(
        OpenAiRoutedProvider provider,
        OpenAiRoutedModel model,
        bool isExactMatch,
        string matchedOn)
    {
        Provider = provider;
        Model = model;
        IsExactMatch = isExactMatch;
        MatchedOn = matchedOn;
    }

    public OpenAiRoutedProvider Provider { get; }
    public OpenAiRoutedModel Model { get; }
    public bool IsExactMatch { get; }
    public string MatchedOn { get; }
}

internal sealed class OpenAiRouteCandidateComparer : IComparer<OpenAiRouteCandidate>
{
    public static OpenAiRouteCandidateComparer Instance { get; } = new();

    public int Compare(OpenAiRouteCandidate? x, OpenAiRouteCandidate? y)
    {
        ArgumentNullException.ThrowIfNull(x);
        ArgumentNullException.ThrowIfNull(y);

        var exactComparison = y.IsExactMatch.CompareTo(x.IsExactMatch);
        if (exactComparison != 0)
        {
            return exactComparison;
        }

        var priorityComparison = y.Model.Priority.CompareTo(x.Model.Priority);
        if (priorityComparison != 0)
        {
            return priorityComparison;
        }

        var recurringFreeComparison = y.Model.IsRecurringFree.CompareTo(x.Model.IsRecurringFree);
        if (recurringFreeComparison != 0)
        {
            return recurringFreeComparison;
        }

        var providerComparison = string.Compare(x.Provider.ProviderId, y.Provider.ProviderId, StringComparison.OrdinalIgnoreCase);
        if (providerComparison != 0)
        {
            return providerComparison;
        }

        return string.Compare(x.Model.ModelId, y.Model.ModelId, StringComparison.OrdinalIgnoreCase);
    }
}

internal sealed class OpenAiRoutedProvider : IDisposable
{
    private OpenAiRoutedProvider(
        string providerId,
        OpenAiClient client,
        IReadOnlyList<OpenAiRoutedModel> models,
        bool disposeClient,
        OpenAiProviderRuntimeState state)
    {
        ProviderId = providerId;
        Client = client;
        Models = models;
        DisposeClient = disposeClient;
        State = state;
    }

    public string ProviderId { get; }
    public OpenAiClient Client { get; }
    public IReadOnlyList<OpenAiRoutedModel> Models { get; }
    public bool DisposeClient { get; }
    public OpenAiProviderRuntimeState State { get; }

    public static OpenAiRoutedProvider Create(
        OpenAiRoutedProviderDefinition definition,
        TimeProvider timeProvider,
        TimeSpan defaultRateLimitCooldown,
        TimeSpan defaultTransientFailureCooldown)
    {
        var state = new OpenAiProviderRuntimeState(
            timeProvider: timeProvider,
            rateLimitCooldown: definition.RateLimitCooldown ?? defaultRateLimitCooldown,
            transientFailureCooldown: definition.TransientFailureCooldown ?? defaultTransientFailureCooldown);

        OpenAiRateLimitRegistry.Register(definition.Client.HttpClient, state);

        return new OpenAiRoutedProvider(
            providerId: definition.ProviderId,
            client: definition.Client,
            models: definition.Models.Select(static model => OpenAiRoutedModel.Create(model)).ToArray(),
            disposeClient: definition.DisposeClient,
            state: state);
    }

    public void Dispose()
    {
        OpenAiRateLimitRegistry.Unregister(Client.HttpClient);
        if (DisposeClient)
        {
            Client.Dispose();
        }
    }
}

internal sealed class OpenAiRoutedModel
{
    private OpenAiRoutedModel(
        string modelId,
        HashSet<string> aliases,
        int priority,
        bool isRecurringFree,
        bool supportsToolCalls,
        bool supportsStructuredOutputs,
        bool supportsStreaming)
    {
        ModelId = modelId;
        Aliases = aliases;
        Priority = priority;
        IsRecurringFree = isRecurringFree;
        SupportsToolCalls = supportsToolCalls;
        SupportsStructuredOutputs = supportsStructuredOutputs;
        SupportsStreaming = supportsStreaming;
    }

    public string ModelId { get; }
    public HashSet<string> Aliases { get; }
    public int Priority { get; }
    public bool IsRecurringFree { get; }
    public bool SupportsToolCalls { get; }
    public bool SupportsStructuredOutputs { get; }
    public bool SupportsStreaming { get; }

    public static OpenAiRoutedModel Create(OpenAiRoutedModelDefinition definition)
    {
        var aliases = new HashSet<string>(definition.Aliases, StringComparer.OrdinalIgnoreCase)
        {
            definition.ModelId,
        };

        return new OpenAiRoutedModel(
            modelId: definition.ModelId,
            aliases: aliases,
            priority: definition.Priority,
            isRecurringFree: definition.IsRecurringFree,
            supportsToolCalls: definition.SupportsToolCalls,
            supportsStructuredOutputs: definition.SupportsStructuredOutputs,
            supportsStreaming: definition.SupportsStreaming);
    }
}
