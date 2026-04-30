using System.Net;
using System.Runtime.CompilerServices;
using System.Text.Json;
using Google.Gemini;
using Meai = Microsoft.Extensions.AI;
using OpenAiApiException = tryAGI.OpenAI.ApiException;

namespace FreeLLM;

/// <summary>
/// Free-first routed chat client with OpenAI-compatible and MEAI surfaces.
/// </summary>
public sealed class FreeLlmClient : Meai.IChatClient, IDisposable
{
    private readonly IReadOnlyList<FreeLlmProvider> _providers;
    private readonly string _defaultAlias;
    private readonly TimeProvider _timeProvider;

    internal FreeLlmClient(
        IReadOnlyList<FreeLlmProvider> providers,
        string defaultAlias,
        TimeProvider timeProvider)
    {
        _providers = providers;
        _defaultAlias = defaultAlias;
        _timeProvider = timeProvider;
        Chat = new FreeLlmChatCompletionsClient(this);
    }

    /// <summary>
    /// OpenAI-compatible chat-completions surface.
    /// </summary>
    public FreeLlmChatCompletionsClient Chat { get; }

    /// <summary>
    /// Returns the current routing and cooldown status for every registered provider.
    /// </summary>
    public IReadOnlyList<FreeLlmProviderStatus> GetProviderStatuses()
        => _providers.Select(static provider => provider.State.GetStatus(provider.ProviderId)).ToArray();

    /// <summary>
    /// Returns the latest discovered model catalog snapshot for every registered provider.
    /// </summary>
    public IReadOnlyList<FreeLlmProviderCatalog> GetProviderCatalogs()
        => _providers.Select(static provider => provider.GetCatalogSnapshot()).ToArray();

    /// <summary>
    /// Refreshes provider model catalogs and returns the latest snapshots.
    /// </summary>
    public async Task<IReadOnlyList<FreeLlmProviderCatalog>> RefreshProviderCatalogsAsync(
        CancellationToken cancellationToken = default)
    {
        await Task.WhenAll(_providers.Select(provider => provider.RefreshCatalogAsync(cancellationToken))).ConfigureAwait(false);
        return GetProviderCatalogs();
    }

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
        await RefreshProviderCatalogsIfNeededAsync(cancellationToken).ConfigureAwait(false);
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
                return await candidate.Provider.GetResponseAsync(chatMessages, routeOptions, cancellationToken).ConfigureAwait(false);
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
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        await RefreshProviderCatalogsIfNeededAsync(cancellationToken).ConfigureAwait(false);
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

            IAsyncEnumerable<Meai.ChatResponseUpdate>? updates = null;
            try
            {
                var routeOptions = CloneOptionsWithModel(options, candidate.Model.ModelId);
                updates = candidate.Provider.GetStreamingResponseAsync(chatMessages, routeOptions, cancellationToken);
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

    internal async Task<tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        CancellationToken cancellationToken)
    {
        await RefreshProviderCatalogsIfNeededAsync(cancellationToken).ConfigureAwait(false);
        var resolvedRequest = ResolveRawRequest(request);
        Exception? lastException = null;
        var attempted = new List<string>();
        var now = _timeProvider.GetUtcNow();

        foreach (var candidate in resolvedRequest.Candidates)
        {
            if (candidate.Provider.State.IsCoolingDown(now))
            {
                continue;
            }

            if (!candidate.Provider.CanCreateChatCompletion(request, requireStreaming: false, out _))
            {
                continue;
            }

            attempted.Add($"{candidate.Provider.ProviderId}:{candidate.Model.ModelId}");

            try
            {
                return await candidate.Provider.CreateChatCompletionAsync(
                    request,
                    candidate.Model.ModelId,
                    cancellationToken).ConfigureAwait(false);
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

    internal async IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        await RefreshProviderCatalogsIfNeededAsync(cancellationToken).ConfigureAwait(false);
        var resolvedRequest = ResolveRawRequest(request, requireStreaming: true);
        Exception? lastException = null;
        var attempted = new List<string>();
        var now = _timeProvider.GetUtcNow();

        foreach (var candidate in resolvedRequest.Candidates)
        {
            if (candidate.Provider.State.IsCoolingDown(now))
            {
                continue;
            }

            if (!candidate.Provider.CanCreateChatCompletion(request, requireStreaming: true, out var _reason))
            {
                continue;
            }

            attempted.Add($"{candidate.Provider.ProviderId}:{candidate.Model.ModelId}");

            IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse>? updates = null;
            try
            {
                updates = candidate.Provider.CreateChatCompletionAsStreamAsync(
                    request,
                    candidate.Model.ModelId,
                    cancellationToken);
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

    private FreeLlmResolvedRequest ResolveCandidates(Meai.ChatOptions? options, bool requireStreaming = false)
    {
        var requestedModelId = string.IsNullOrWhiteSpace(options?.ModelId)
            ? _defaultAlias
            : options!.ModelId!;

        var requiresTools = options?.Tools is { Count: > 0 };
        var requiresStructuredOutputs = options?.ResponseFormat is Meai.ChatResponseFormatJson;

        return ResolveCandidates(
            requestedModelId,
            requiresTools,
            requiresStructuredOutputs,
            requireStreaming);
    }

    private FreeLlmResolvedRequest ResolveRawRequest(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        bool requireStreaming = false)
    {
        if (request.CreateChatCompletionRequestVariant2 is not { } variant)
        {
            throw new NotSupportedException(
                $"Only {nameof(tryAGI.OpenAI.CreateChatCompletionRequestVariant2)} is currently supported by {nameof(FreeLlmClient)}.");
        }

        var requestedModelId = string.IsNullOrWhiteSpace(variant.Model.ToString())
            ? _defaultAlias
            : variant.Model.ToString()!;
        var requiresTools = variant.Tools is { Count: > 0 } || variant.Functions is { Count: > 0 };
        var requiresStructuredOutputs = variant.ResponseFormat is { IsJsonObject: true } or { IsJsonSchema: true };

        return ResolveCandidates(
            requestedModelId,
            requiresTools,
            requiresStructuredOutputs,
            requireStreaming || variant.Stream == true);
    }

    private FreeLlmResolvedRequest ResolveCandidates(
        string requestedModelId,
        bool requiresTools,
        bool requiresStructuredOutputs,
        bool requireStreaming)
    {
        var requestedIds = GetRequestedIds(requestedModelId);
        var resolved = new List<FreeLlmRouteCandidate>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var requestedId in requestedIds)
        {
            foreach (var provider in _providers)
            {
                foreach (var model in provider.GetRoutingModels())
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

                    resolved.Add(new FreeLlmRouteCandidate(
                        provider: provider,
                        model: model,
                        isExactModelMatch: isExactMatch,
                        matchedPriority: model.GetPriority(requestedId, isExactMatch)));
                }
            }
        }

        if (resolved.Count == 0)
        {
            throw new InvalidOperationException(
                $"No routed models matched '{requestedModelId}'. Register an exact model id or alias in {nameof(FreeLlmClientBuilder)}.");
        }

        resolved.Sort(static (left, right) =>
        {
            var exactComparison = right.IsExactModelMatch.CompareTo(left.IsExactModelMatch);
            if (exactComparison != 0)
            {
                return exactComparison;
            }

            var priorityComparison = right.EffectivePriority.CompareTo(left.EffectivePriority);
            if (priorityComparison != 0)
            {
                return priorityComparison;
            }

            var providerPriorityComparison = right.Provider.Priority.CompareTo(left.Provider.Priority);
            if (providerPriorityComparison != 0)
            {
                return providerPriorityComparison;
            }

            var modelPriorityComparison = right.MatchedPriority.CompareTo(left.MatchedPriority);
            if (modelPriorityComparison != 0)
            {
                return modelPriorityComparison;
            }

            var freeComparison = right.Model.IsRecurringFree.CompareTo(left.Model.IsRecurringFree);
            if (freeComparison != 0)
            {
                return freeComparison;
            }

            var providerComparison = string.Compare(left.Provider.ProviderId, right.Provider.ProviderId, StringComparison.OrdinalIgnoreCase);
            if (providerComparison != 0)
            {
                return providerComparison;
            }

            return string.Compare(left.Model.ModelId, right.Model.ModelId, StringComparison.OrdinalIgnoreCase);
        });

        return new FreeLlmResolvedRequest(requestedModelId, resolved);
    }

    private static List<string> GetRequestedIds(string requestedModelId)
    {
        var requestedIds = new List<string> { requestedModelId };
        if (string.Equals(requestedModelId, FreeLlmModelAliases.Smart, StringComparison.OrdinalIgnoreCase))
        {
            requestedIds.Add(FreeLlmModelAliases.SmartAny);
        }

        return requestedIds;
    }

    private static Meai.ChatOptions CloneOptionsWithModel(Meai.ChatOptions? options, string modelId)
    {
        var clone = options?.Clone() ?? new Meai.ChatOptions();
        clone.ModelId = modelId;
        return clone;
    }

    private static bool ShouldFallback(
        Exception exception,
        string requestedModelId,
        FreeLlmRouteCandidate candidate)
    {
        var isAliasRequest = !string.Equals(requestedModelId, candidate.Model.ModelId, StringComparison.OrdinalIgnoreCase);

        return exception switch
        {
            OpenAiApiException openAiException => ShouldFallback(openAiException.StatusCode, isAliasRequest),
            Google.Gemini.ApiException geminiException => ShouldFallback(geminiException.StatusCode, isAliasRequest),
            TimeoutException or HttpRequestException => true,
            _ => false,
        };
    }

    private static bool ShouldFallback(HttpStatusCode statusCode, bool isAliasRequest)
        => statusCode == HttpStatusCode.TooManyRequests ||
           statusCode == HttpStatusCode.RequestTimeout ||
           (int)statusCode >= 500 ||
           (isAliasRequest && statusCode is HttpStatusCode.BadRequest or HttpStatusCode.NotFound or HttpStatusCode.Conflict);

    private static InvalidOperationException CreateNoAvailableProviderException(string requestedModelId, IEnumerable<string> attempted)
        => new InvalidOperationException(
            $"No providers were available for '{requestedModelId}'. Attempted: {string.Join(", ", attempted)}");

    private async Task RefreshProviderCatalogsIfNeededAsync(CancellationToken cancellationToken)
    {
        var now = _timeProvider.GetUtcNow();
        var refreshTasks = _providers
            .Where(provider => provider.ShouldRefreshCatalog(now))
            .Select(provider => provider.RefreshCatalogAsync(cancellationToken))
            .ToArray();

        if (refreshTasks.Length == 0)
        {
            return;
        }

        await Task.WhenAll(refreshTasks).ConfigureAwait(false);
    }
}

/// <summary>
/// OpenAI-compatible chat-completions surface over <see cref="FreeLlmClient"/>.
/// </summary>
public sealed class FreeLlmChatCompletionsClient
{
    private readonly FreeLlmClient _client;

    internal FreeLlmChatCompletionsClient(FreeLlmClient client)
    {
        _client = client;
    }

    public Task<tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        CancellationToken cancellationToken = default)
        => _client.CreateChatCompletionAsync(request, cancellationToken);

    public IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        CancellationToken cancellationToken = default)
        => _client.CreateChatCompletionAsStreamAsync(request, cancellationToken);
}

internal sealed class FreeLlmResolvedRequest
{
    public FreeLlmResolvedRequest(string requestedModelId, IReadOnlyList<FreeLlmRouteCandidate> candidates)
    {
        RequestedModelId = requestedModelId;
        Candidates = candidates;
    }

    public string RequestedModelId { get; }

    public IReadOnlyList<FreeLlmRouteCandidate> Candidates { get; }
}

internal sealed class FreeLlmRouteCandidate
{
    public FreeLlmRouteCandidate(
        FreeLlmProvider provider,
        FreeLlmModel model,
        bool isExactModelMatch,
        int matchedPriority)
    {
        Provider = provider;
        Model = model;
        IsExactModelMatch = isExactModelMatch;
        MatchedPriority = matchedPriority;
        EffectivePriority = provider.Priority + matchedPriority;
    }

    public FreeLlmProvider Provider { get; }

    public FreeLlmModel Model { get; }

    public bool IsExactModelMatch { get; }

    public int MatchedPriority { get; }

    public int EffectivePriority { get; }
}

internal sealed class FreeLlmModel
{
    private FreeLlmModel(
        string modelId,
        ISet<string> aliases,
        IReadOnlyDictionary<string, int> aliasPriorities,
        int priority,
        bool isRecurringFree,
        bool supportsToolCalls,
        bool supportsStructuredOutputs,
        bool supportsStreaming)
    {
        ModelId = modelId;
        Aliases = aliases;
        AliasPriorities = aliasPriorities;
        Priority = priority;
        IsRecurringFree = isRecurringFree;
        SupportsToolCalls = supportsToolCalls;
        SupportsStructuredOutputs = supportsStructuredOutputs;
        SupportsStreaming = supportsStreaming;
    }

    public string ModelId { get; }

    public ISet<string> Aliases { get; }

    public IReadOnlyDictionary<string, int> AliasPriorities { get; }

    public int Priority { get; }

    public bool IsRecurringFree { get; }

    public bool SupportsToolCalls { get; }

    public bool SupportsStructuredOutputs { get; }

    public bool SupportsStreaming { get; }

    public static FreeLlmModel Create(FreeLlmModelDefinition definition)
    {
        ArgumentNullException.ThrowIfNull(definition);

        return new FreeLlmModel(
            modelId: definition.ModelId,
            aliases: new HashSet<string>(definition.Aliases, StringComparer.OrdinalIgnoreCase),
            aliasPriorities: new Dictionary<string, int>(definition.AliasPriorities, StringComparer.OrdinalIgnoreCase),
            priority: definition.Priority,
            isRecurringFree: definition.IsRecurringFree,
            supportsToolCalls: definition.SupportsToolCalls,
            supportsStructuredOutputs: definition.SupportsStructuredOutputs,
            supportsStreaming: definition.SupportsStreaming);
    }

    public int GetPriority(string requestedId, bool isExactMatch)
    {
        if (isExactMatch)
        {
            return Priority;
        }

        return AliasPriorities.TryGetValue(requestedId, out var aliasPriority)
            ? aliasPriority
            : Priority;
    }
}

internal abstract class FreeLlmProvider : IDisposable
{
    protected FreeLlmProvider(
        string providerId,
        int priority,
        IReadOnlyList<FreeLlmModel> models,
        FreeLlmProviderRuntimeState state,
        FreeLlmProviderCatalogRuntimeState catalogState)
    {
        ProviderId = providerId;
        Priority = priority;
        Models = models;
        State = state;
        CatalogState = catalogState;
    }

    public string ProviderId { get; }

    public int Priority { get; }

    public IReadOnlyList<FreeLlmModel> Models { get; }

    public FreeLlmProviderRuntimeState State { get; }

    public FreeLlmProviderCatalogRuntimeState CatalogState { get; }

    public IReadOnlyList<FreeLlmModel> GetRoutingModels()
        => CatalogState.GetRoutingModels(Models);

    public bool ShouldRefreshCatalog(DateTimeOffset now)
        => CatalogState.ShouldRefresh(now);

    public Task RefreshCatalogAsync(CancellationToken cancellationToken)
        => CatalogState.RefreshAsync(ListModelIdsAsync, cancellationToken);

    public FreeLlmProviderCatalog GetCatalogSnapshot()
        => CatalogState.GetSnapshot(ProviderId, Models);

    public abstract Task<Meai.ChatResponse> GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken);

    public abstract IAsyncEnumerable<Meai.ChatResponseUpdate> GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken);

    public abstract bool CanCreateChatCompletion(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        bool requireStreaming,
        out string? reason);

    public abstract Task<tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        CancellationToken cancellationToken);

    public abstract IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        CancellationToken cancellationToken);

    protected abstract Task<IReadOnlyList<string>> ListModelIdsAsync(CancellationToken cancellationToken);

    public abstract void Dispose();
}

internal sealed class FreeLlmOpenAiProvider : FreeLlmProvider
{
    private readonly tryAGI.OpenAI.OpenAiClient _client;
    private readonly bool _disposeClient;

    public FreeLlmOpenAiProvider(
        string providerId,
        int priority,
        tryAGI.OpenAI.OpenAiClient client,
        IReadOnlyList<FreeLlmModel> models,
        FreeLlmProviderRuntimeState state,
        FreeLlmProviderCatalogRuntimeState catalogState,
        bool disposeClient)
        : base(providerId, priority, models, state, catalogState)
    {
        _client = client;
        _disposeClient = disposeClient;
    }

    public override Task<Meai.ChatResponse> GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken)
    {
        Meai.IChatClient chatClient = _client;
        return chatClient.GetResponseAsync(messages, options, cancellationToken);
    }

    public override IAsyncEnumerable<Meai.ChatResponseUpdate> GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken)
    {
        Meai.IChatClient chatClient = _client;
        return chatClient.GetStreamingResponseAsync(messages, options, cancellationToken);
    }

    public override bool CanCreateChatCompletion(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        bool requireStreaming,
        out string? reason)
    {
        reason = request.CreateChatCompletionRequestVariant2 is null
            ? $"Only {nameof(tryAGI.OpenAI.CreateChatCompletionRequestVariant2)} is currently supported."
            : null;
        return reason is null;
    }

    public override Task<tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        CancellationToken cancellationToken)
        => _client.Chat.CreateChatCompletionAsync(
            request: FreeLlmOpenAiCompat.CloneRequestWithModel(request, modelId),
            cancellationToken: cancellationToken);

    public override IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        CancellationToken cancellationToken)
        => _client.Chat.CreateChatCompletionAsStreamAsync(
            request: FreeLlmOpenAiCompat.CloneRequestWithModel(request, modelId),
            cancellationToken: cancellationToken);

    protected override Task<IReadOnlyList<string>> ListModelIdsAsync(CancellationToken cancellationToken)
        => FreeLlmModelCatalogClient.ListOpenAiCompatibleModelsAsync(_client, cancellationToken);

    public override void Dispose()
    {
        CatalogState.Dispose();
        if (_disposeClient)
        {
            _client.Dispose();
        }
    }
}

internal sealed class FreeLlmGeminiProvider : FreeLlmProvider
{
    private readonly GeminiClient _client;
    private readonly bool _disposeClient;

    public FreeLlmGeminiProvider(
        string providerId,
        int priority,
        GeminiClient client,
        IReadOnlyList<FreeLlmModel> models,
        FreeLlmProviderRuntimeState state,
        FreeLlmProviderCatalogRuntimeState catalogState,
        bool disposeClient)
        : base(providerId, priority, models, state, catalogState)
    {
        _client = client;
        _disposeClient = disposeClient;
    }

    public override Task<Meai.ChatResponse> GetResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken)
    {
        Meai.IChatClient chatClient = _client;
        return chatClient.GetResponseAsync(messages, options, cancellationToken);
    }

    public override IAsyncEnumerable<Meai.ChatResponseUpdate> GetStreamingResponseAsync(
        IEnumerable<Meai.ChatMessage> messages,
        Meai.ChatOptions options,
        CancellationToken cancellationToken)
    {
        Meai.IChatClient chatClient = _client;
        return chatClient.GetStreamingResponseAsync(messages, options, cancellationToken);
    }

    public override bool CanCreateChatCompletion(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        bool requireStreaming,
        out string? reason)
        => FreeLlmOpenAiCompat.TryTranslateRequest(request, modelId: null, requireStreaming, out _, out reason);

    public override async Task<tryAGI.OpenAI.CreateChatCompletionResponse> CreateChatCompletionAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        CancellationToken cancellationToken)
    {
        if (!FreeLlmOpenAiCompat.TryTranslateRequest(request, modelId, requireStreaming: false, out var translated, out var reason))
        {
            throw new NotSupportedException(reason);
        }

        Meai.IChatClient chatClient = _client;
        var response = await chatClient.GetResponseAsync(
            translated!.Messages,
            translated.Options,
            cancellationToken).ConfigureAwait(false);

        return FreeLlmOpenAiCompat.ToCreateChatCompletionResponse(response, fallbackModelId: modelId);
    }

    public override async IAsyncEnumerable<tryAGI.OpenAI.CreateChatCompletionStreamResponse> CreateChatCompletionAsStreamAsync(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId,
        [EnumeratorCancellation] CancellationToken cancellationToken)
    {
        if (!FreeLlmOpenAiCompat.TryTranslateRequest(request, modelId, requireStreaming: true, out var translated, out var reason))
        {
            throw new NotSupportedException(reason);
        }

        Meai.IChatClient chatClient = _client;
        await foreach (var update in chatClient.GetStreamingResponseAsync(
                           translated!.Messages,
                           translated.Options,
                           cancellationToken).ConfigureAwait(false))
        {
            yield return FreeLlmOpenAiCompat.ToCreateChatCompletionStreamResponse(update, fallbackModelId: modelId);
        }
    }

    protected override Task<IReadOnlyList<string>> ListModelIdsAsync(CancellationToken cancellationToken)
        => FreeLlmModelCatalogClient.ListGeminiModelsAsync(_client, cancellationToken);

    public override void Dispose()
    {
        CatalogState.Dispose();
        if (_disposeClient)
        {
            _client.Dispose();
        }
    }
}

internal sealed class FreeLlmTranslatedRequest
{
    public FreeLlmTranslatedRequest(
        IReadOnlyList<Meai.ChatMessage> messages,
        Meai.ChatOptions options)
    {
        Messages = messages;
        Options = options;
    }

    public IReadOnlyList<Meai.ChatMessage> Messages { get; }

    public Meai.ChatOptions Options { get; }
}

internal static class FreeLlmOpenAiCompat
{
    public static bool TryTranslateRequest(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string? modelId,
        bool requireStreaming,
        out FreeLlmTranslatedRequest? translated,
        out string? reason)
    {
        translated = null;

        if (request.CreateChatCompletionRequestVariant2 is not { } variant)
        {
            reason = $"Only {nameof(tryAGI.OpenAI.CreateChatCompletionRequestVariant2)} is currently supported.";
            return false;
        }

        if (variant.N is > 1)
        {
            reason = "Gemini fallback currently supports only single-choice chat completions (`n = 1`).";
            return false;
        }

        if (variant.Logprobs == true || variant.TopLogprobs is not null)
        {
            reason = "Gemini fallback does not support OpenAI logprobs fields.";
            return false;
        }

        if (variant.Audio is not null || variant.Modalities is { Count: > 0 })
        {
            reason = "Gemini fallback in FreeLLM currently supports text chat completions only.";
            return false;
        }

        if (variant.WebSearchOptions is not null || variant.Prediction is not null)
        {
            reason = "Gemini fallback does not support web search or predicted outputs through the OpenAI-compatible adapter.";
            return false;
        }

        if (variant.Tools is { Count: > 0 } || variant.Functions is { Count: > 0 } || variant.FunctionCall is not null)
        {
            reason = "Gemini fallback does not currently translate raw OpenAI tool schemas. Use the MEAI surface for Gemini tool calling.";
            return false;
        }

        var messages = new List<Meai.ChatMessage>(variant.Messages.Count);
        foreach (var message in variant.Messages)
        {
            if (!TryConvertMessage(message, messages, out reason))
            {
                return false;
            }
        }

        var options = new Meai.ChatOptions
        {
            ModelId = modelId ?? variant.Model.ToString(),
            MaxOutputTokens = variant.MaxCompletionTokens ?? variant.MaxTokens,
            FrequencyPenalty = variant.FrequencyPenalty is { } frequencyPenalty ? (float)frequencyPenalty : null,
            PresencePenalty = variant.PresencePenalty is { } presencePenalty ? (float)presencePenalty : null,
            Seed = variant.Seed,
        };

        if (variant.Stop is { IsStopConfigurationVariant1: true, StopConfigurationVariant1: { } stopSequence })
        {
            options.StopSequences = [stopSequence];
        }
        else if (variant.Stop is { IsStopConfigurationVariant2: true, StopConfigurationVariant2: { Count: > 0 } stopSequences })
        {
            options.StopSequences = stopSequences.ToList();
        }

        if (variant.ResponseFormat is { IsText: true })
        {
            options.ResponseFormat = Meai.ChatResponseFormat.Text;
        }
        else if (variant.ResponseFormat is { IsJsonObject: true })
        {
            options.ResponseFormat = new Meai.ChatResponseFormatJson(schema: null);
        }
        else if (variant.ResponseFormat is { IsJsonSchema: true, JsonSchema: { JsonSchema: { } jsonSchema } })
        {
            JsonElement? schema = null;
            if (jsonSchema.Schema is { AdditionalProperties.Count: > 0 } schemaObject)
            {
                schema = JsonSerializer.SerializeToElement(schemaObject.AdditionalProperties);
            }

            options.ResponseFormat = new Meai.ChatResponseFormatJson(
                schema,
                jsonSchema.Name,
                jsonSchema.Description);
        }

        if (variant.AdditionalProperties.Count > 0)
        {
            if (TryGetSingle(variant.AdditionalProperties, "temperature", out var temperature))
            {
                options.Temperature = temperature;
            }

            if (TryGetSingle(variant.AdditionalProperties, "top_p", out var topP))
            {
                options.TopP = topP;
            }
        }

        translated = new FreeLlmTranslatedRequest(messages, options);
        reason = null;
        return !requireStreaming || variant.Stream == true || requireStreaming;
    }

    public static tryAGI.OpenAI.CreateChatCompletionRequest CloneRequestWithModel(
        tryAGI.OpenAI.CreateChatCompletionRequest request,
        string modelId)
    {
        if (request.CreateChatCompletionRequestVariant2 is not { } variant)
        {
            throw new NotSupportedException(
                $"Only {nameof(tryAGI.OpenAI.CreateChatCompletionRequestVariant2)} is currently supported.");
        }

        var json = JsonSerializer.Serialize(variant);
        var clone = JsonSerializer.Deserialize<tryAGI.OpenAI.CreateChatCompletionRequestVariant2>(json)
                    ?? throw new InvalidOperationException("Failed to clone chat completion request.");
        clone.Model = modelId;

        return new tryAGI.OpenAI.CreateChatCompletionRequest
        {
            CreateChatCompletionRequestVariant2 = clone,
        };
    }

    public static tryAGI.OpenAI.CreateChatCompletionResponse ToCreateChatCompletionResponse(
        Meai.ChatResponse response,
        string fallbackModelId)
    {
        var messages = response.Messages.Count == 0
            ? [new Meai.ChatMessage(Meai.ChatRole.Assistant, string.Empty)]
            : response.Messages.ToList();

        var choices = new List<tryAGI.OpenAI.CreateChatCompletionResponseChoice>(messages.Count);
        for (var index = 0; index < messages.Count; index++)
        {
            var message = messages[index];
            choices.Add(new tryAGI.OpenAI.CreateChatCompletionResponseChoice
            {
                Index = index,
                FinishReason = ToFinishReason(response.FinishReason, message),
                Message = new tryAGI.OpenAI.ChatCompletionResponseMessage
                {
                    Role = tryAGI.OpenAI.ChatCompletionResponseMessageRole.Assistant,
                    Content = string.Concat(message.Contents.OfType<Meai.TextContent>().Select(static content => content.Text)),
                    ToolCalls = CreateToolCalls(message),
                },
            });
        }

        return new tryAGI.OpenAI.CreateChatCompletionResponse
        {
            Id = string.IsNullOrWhiteSpace(response.ResponseId) ? $"free-{Guid.NewGuid():N}" : response.ResponseId!,
            Choices = choices,
            Created = (int)(response.CreatedAt ?? DateTimeOffset.UtcNow).ToUnixTimeSeconds(),
            Model = string.IsNullOrWhiteSpace(response.ModelId) ? fallbackModelId : response.ModelId!,
            Object = tryAGI.OpenAI.CreateChatCompletionResponseObject.ChatCompletion,
            Usage = CreateUsage(response.Usage),
        };
    }

    public static tryAGI.OpenAI.CreateChatCompletionStreamResponse ToCreateChatCompletionStreamResponse(
        Meai.ChatResponseUpdate update,
        string fallbackModelId)
    {
        var usage = update.Contents.OfType<Meai.UsageContent>().LastOrDefault();
        var text = string.Concat(update.Contents.OfType<Meai.TextContent>().Select(static content => content.Text));
        var functionCalls = update.Contents.OfType<Meai.FunctionCallContent>().ToList();

        var choices = usage is not null && string.IsNullOrEmpty(text) && functionCalls.Count == 0 && update.Role is null
            ? new List<tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice>()
            : [new tryAGI.OpenAI.CreateChatCompletionStreamResponseChoice
            {
                Index = 0,
                FinishReason = ToStreamFinishReason(update.FinishReason, functionCalls.Count > 0),
                Delta = new tryAGI.OpenAI.ChatCompletionStreamResponseDelta
                {
                    Role = update.Role == Meai.ChatRole.Assistant
                        ? tryAGI.OpenAI.ChatCompletionStreamResponseDeltaRole.Assistant
                        : null,
                    Content = string.IsNullOrEmpty(text) ? null : text,
                    ToolCalls = CreateToolCallChunks(functionCalls),
                },
            }];

        return new tryAGI.OpenAI.CreateChatCompletionStreamResponse
        {
            Id = string.IsNullOrWhiteSpace(update.ResponseId) ? $"free-{Guid.NewGuid():N}" : update.ResponseId!,
            Choices = choices,
            Created = (int)(update.CreatedAt ?? DateTimeOffset.UtcNow).ToUnixTimeSeconds(),
            Model = string.IsNullOrWhiteSpace(update.ModelId) ? fallbackModelId : update.ModelId!,
            Object = tryAGI.OpenAI.CreateChatCompletionStreamResponseObject.ChatCompletionChunk,
            Usage = usage is null ? null : CreateUsage(usage.Details),
        };
    }

    private static bool TryConvertMessage(
        tryAGI.OpenAI.ChatCompletionRequestMessage message,
        List<Meai.ChatMessage> messages,
        out string? reason)
    {
        if (message.IsDeveloper && message.Developer is { } developer)
        {
            messages.Add(new Meai.ChatMessage
            {
                Role = Meai.ChatRole.System,
                Contents = [new Meai.TextContent(ExtractText(developer.Content))],
            });
            reason = null;
            return true;
        }

        if (message.IsSystem && message.System is { } system)
        {
            messages.Add(new Meai.ChatMessage
            {
                Role = Meai.ChatRole.System,
                Contents = [new Meai.TextContent(ExtractText(system.Content))],
            });
            reason = null;
            return true;
        }

        if (message.IsUser && message.User is { } user)
        {
            var chatMessage = new Meai.ChatMessage { Role = Meai.ChatRole.User };
            if (user.Content.IsValue1)
            {
                chatMessage.Contents.Add(new Meai.TextContent(user.Content.Value1 ?? string.Empty));
            }
            else if (user.Content.Value2 is { } parts)
            {
                foreach (var part in parts)
                {
                    if (part.IsTextContentPart && part.TextContentPart is { } textPart)
                    {
                        chatMessage.Contents.Add(new Meai.TextContent(textPart.Text ?? string.Empty));
                    }
                    else if (part.IsImageContentPart && part.ImageContentPart?.ImageUrl?.Url is { } imageUrl)
                    {
                        if (Uri.TryCreate(imageUrl, UriKind.Absolute, out var uri) &&
                            uri.Scheme.Equals("data", StringComparison.OrdinalIgnoreCase))
                        {
                            if (!TryParseDataUri(imageUrl, out var bytes, out var mediaType))
                            {
                                reason = "Failed to parse data URI image content.";
                                return false;
                            }

                            chatMessage.Contents.Add(new Meai.DataContent(bytes, mediaType));
                        }
                        else
                        {
                            reason = "Gemini fallback currently supports image inputs only as data URIs.";
                            return false;
                        }
                    }
                    else
                    {
                        reason = "Gemini fallback currently supports only text and image content parts in OpenAI-compatible user messages.";
                        return false;
                    }
                }
            }

            messages.Add(chatMessage);
            reason = null;
            return true;
        }

        if (message.IsAssistant && message.Assistant is { } assistant)
        {
            var chatMessage = new Meai.ChatMessage { Role = Meai.ChatRole.Assistant };

            if (assistant.Content is { IsValue1: true, Value1: { } textContent })
            {
                chatMessage.Contents.Add(new Meai.TextContent(textContent));
            }
            else if (assistant.Content?.Value2 is { } parts)
            {
                foreach (var part in parts)
                {
                    if (part.IsText && part.Text is { } textPart)
                    {
                        chatMessage.Contents.Add(new Meai.TextContent(textPart.Text ?? string.Empty));
                    }
                    else if (part.IsRefusal && part.Refusal is { } refusalPart)
                    {
                        chatMessage.Contents.Add(new Meai.TextContent(refusalPart.Refusal));
                    }
                }
            }

            if (assistant.ToolCalls is { Count: > 0 })
            {
                foreach (var toolCall in assistant.ToolCalls)
                {
                    if (!toolCall.IsFunction || toolCall.Function?.Function is not { } function)
                    {
                        reason = "Gemini fallback currently supports only function tool calls in assistant messages.";
                        return false;
                    }

                    chatMessage.Contents.Add(new Meai.FunctionCallContent(
                        callId: toolCall.Function.Id,
                        name: function.Name,
                        arguments: ParseArguments(function.Arguments)));
                }
            }

            messages.Add(chatMessage);
            reason = null;
            return true;
        }

        if (message.IsTool && message.Tool is { } tool)
        {
            messages.Add(new Meai.ChatMessage
            {
                Role = Meai.ChatRole.Tool,
                Contents =
                [
                    new Meai.FunctionResultContent(
                        tool.ToolCallId,
                        tool.Content.IsValue1
                            ? tool.Content.Value1
                            : string.Concat(tool.Content.Value2?.Select(static part => part.TextContentPart?.Text) ?? [])),
                ],
            });
            reason = null;
            return true;
        }

        reason = "Gemini fallback does not support legacy function messages in the OpenAI-compatible adapter.";
        return false;
    }

    private static string ExtractText(tryAGI.OpenAI.OneOf<string, IList<tryAGI.OpenAI.ChatCompletionRequestMessageContentPartText>> content)
        => content.IsValue1
            ? content.Value1 ?? string.Empty
            : string.Concat(content.Value2?.Select(static part => part.Text) ?? []);

    private static string ExtractText(tryAGI.OpenAI.OneOf<string, IList<tryAGI.OpenAI.ChatCompletionRequestSystemMessageContentPart>> content)
        => content.IsValue1
            ? content.Value1 ?? string.Empty
            : string.Concat(content.Value2?.Select(static part => part.TextContentPart?.Text) ?? []);

    private static bool TryParseDataUri(
        string value,
        out ReadOnlyMemory<byte> bytes,
        out string mediaType)
    {
        bytes = default;
        mediaType = "application/octet-stream";

        const string prefix = "data:";
        if (!value.StartsWith(prefix, StringComparison.OrdinalIgnoreCase))
        {
            return false;
        }

        var commaIndex = value.IndexOf(',', StringComparison.Ordinal);
        if (commaIndex < 0)
        {
            return false;
        }

        var header = value[prefix.Length..commaIndex];
        var payload = value[(commaIndex + 1)..];
        var segments = header.Split(';', StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        mediaType = segments.FirstOrDefault(static segment => !segment.Equals("base64", StringComparison.OrdinalIgnoreCase))
                    ?? mediaType;

        try
        {
            bytes = Convert.FromBase64String(payload);
            return true;
        }
        catch (FormatException)
        {
            return false;
        }
    }

    private static Dictionary<string, object?> ParseArguments(string? json)
    {
        if (string.IsNullOrWhiteSpace(json))
        {
            return [];
        }

        try
        {
            return JsonSerializer.Deserialize<Dictionary<string, object?>>(json) ?? [];
        }
        catch (JsonException)
        {
            return [];
        }
    }

    private static tryAGI.OpenAI.ChatCompletionMessageToolCallsItem[]? CreateToolCalls(Meai.ChatMessage message)
    {
        var toolCalls = message.Contents.OfType<Meai.FunctionCallContent>().ToList();
        if (toolCalls.Count == 0)
        {
            return null;
        }

        return toolCalls.Select(static call => (tryAGI.OpenAI.ChatCompletionMessageToolCallsItem)new tryAGI.OpenAI.ChatCompletionMessageToolCall
        {
            Id = string.IsNullOrWhiteSpace(call.CallId) ? $"call_{Guid.NewGuid():N}" : call.CallId!,
            Type = tryAGI.OpenAI.ChatCompletionMessageToolCallType.Function,
            Function = new tryAGI.OpenAI.ChatCompletionMessageToolCallFunction
            {
                Name = call.Name ?? string.Empty,
                Arguments = JsonSerializer.Serialize(call.Arguments ?? (IDictionary<string, object?>)new Dictionary<string, object?>()),
            },
        }).ToArray();
    }

    private static tryAGI.OpenAI.ChatCompletionMessageToolCallChunk[]? CreateToolCallChunks(List<Meai.FunctionCallContent> toolCalls)
    {
        if (toolCalls.Count == 0)
        {
            return null;
        }

        return toolCalls.Select(static (call, index) => new tryAGI.OpenAI.ChatCompletionMessageToolCallChunk
        {
            Index = index,
            Id = string.IsNullOrWhiteSpace(call.CallId) ? $"call_{Guid.NewGuid():N}" : call.CallId!,
            Type = tryAGI.OpenAI.ChatCompletionMessageToolCallChunkType.Function,
            Function = new tryAGI.OpenAI.ChatCompletionMessageToolCallChunkFunction
            {
                Name = call.Name,
                Arguments = JsonSerializer.Serialize(call.Arguments ?? (IDictionary<string, object?>)new Dictionary<string, object?>()),
            },
        }).ToArray();
    }

    private static tryAGI.OpenAI.CompletionUsage? CreateUsage(Meai.UsageDetails? usage)
    {
        if (usage is null)
        {
            return null;
        }

        return new tryAGI.OpenAI.CompletionUsage
        {
            PromptTokens = ClampToInt32(usage.InputTokenCount ?? 0),
            CompletionTokens = ClampToInt32(usage.OutputTokenCount ?? 0),
            TotalTokens = ClampToInt32(usage.TotalTokenCount ?? 0),
        };
    }

    private static int ClampToInt32(long value)
        => value > int.MaxValue ? int.MaxValue : (int)Math.Max(value, 0);

    private static tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason ToFinishReason(
        Meai.ChatFinishReason? finishReason,
        Meai.ChatMessage message)
    {
        if (message.Contents.OfType<Meai.FunctionCallContent>().Any())
        {
            return tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason.ToolCalls;
        }

        if (finishReason == Meai.ChatFinishReason.Length)
        {
            return tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason.Length;
        }

        if (finishReason == Meai.ChatFinishReason.ContentFilter)
        {
            return tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason.ContentFilter;
        }

        if (finishReason == Meai.ChatFinishReason.ToolCalls)
        {
            return tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason.ToolCalls;
        }

        return tryAGI.OpenAI.CreateChatCompletionResponseChoiceFinishReason.Stop;
    }

    private static tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason? ToStreamFinishReason(
        Meai.ChatFinishReason? finishReason,
        bool hasToolCalls)
    {
        if (hasToolCalls)
        {
            return tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls;
        }

        if (finishReason == Meai.ChatFinishReason.Length)
        {
            return tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason.Length;
        }

        if (finishReason == Meai.ChatFinishReason.ContentFilter)
        {
            return tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason.ContentFilter;
        }

        if (finishReason == Meai.ChatFinishReason.ToolCalls)
        {
            return tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason.ToolCalls;
        }

        if (finishReason == Meai.ChatFinishReason.Stop)
        {
            return tryAGI.OpenAI.CreateChatCompletionStreamResponseChoiceFinishReason.Stop;
        }

        return null;
    }

    private static bool TryGetSingle(IDictionary<string, object> additionalProperties, string key, out float value)
    {
        value = default;
        if (!additionalProperties.TryGetValue(key, out var raw) || raw is null)
        {
            return false;
        }

        switch (raw)
        {
            case float floatValue:
                value = floatValue;
                return true;
            case double doubleValue:
                value = (float)doubleValue;
                return true;
            case int intValue:
                value = intValue;
                return true;
            case long longValue:
                value = longValue;
                return true;
            case JsonElement { ValueKind: JsonValueKind.Number } jsonElement when jsonElement.TryGetSingle(out var jsonSingle):
                value = jsonSingle;
                return true;
        }

        return false;
    }
}
