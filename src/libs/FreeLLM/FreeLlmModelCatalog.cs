using System.Net.Http.Headers;
using System.Text.Json;
using Google.Gemini;
using tryAGI.OpenAI;

namespace FreeLLM;

/// <summary>
/// Current catalog state for one provider.
/// </summary>
public sealed class FreeLlmProviderCatalog
{
    internal FreeLlmProviderCatalog(
        string providerId,
        DateTimeOffset? refreshedAt,
        DateTimeOffset? nextRefreshAt,
        TimeSpan? refreshInterval,
        bool filterMissingConfiguredModels,
        bool routeDiscoveredModels,
        string? lastError,
        IReadOnlyList<string> missingConfiguredModelIds,
        IReadOnlyList<FreeLlmCatalogModel> models)
    {
        ProviderId = providerId;
        RefreshedAt = refreshedAt;
        NextRefreshAt = nextRefreshAt;
        RefreshInterval = refreshInterval;
        FilterMissingConfiguredModels = filterMissingConfiguredModels;
        RouteDiscoveredModels = routeDiscoveredModels;
        LastError = lastError;
        MissingConfiguredModelIds = missingConfiguredModelIds;
        Models = models;
    }

    public string ProviderId { get; }

    public DateTimeOffset? RefreshedAt { get; }

    public DateTimeOffset? NextRefreshAt { get; }

    public TimeSpan? RefreshInterval { get; }

    public bool FilterMissingConfiguredModels { get; }

    public bool RouteDiscoveredModels { get; }

    public string? LastError { get; }

    public IReadOnlyList<string> MissingConfiguredModelIds { get; }

    public IReadOnlyList<FreeLlmCatalogModel> Models { get; }
}

/// <summary>
/// Catalog information for one model on one provider.
/// </summary>
public sealed class FreeLlmCatalogModel
{
    internal FreeLlmCatalogModel(
        string modelId,
        bool isConfigured,
        bool isDiscovered,
        bool? isPresentInLatestCatalog,
        bool isRoutable,
        bool isRecurringFree,
        IReadOnlyList<string> aliases)
    {
        ModelId = modelId;
        IsConfigured = isConfigured;
        IsDiscovered = isDiscovered;
        IsPresentInLatestCatalog = isPresentInLatestCatalog;
        IsRoutable = isRoutable;
        IsRecurringFree = isRecurringFree;
        Aliases = aliases;
    }

    public string ModelId { get; }

    public bool IsConfigured { get; }

    public bool IsDiscovered { get; }

    public bool? IsPresentInLatestCatalog { get; }

    public bool IsRoutable { get; }

    public bool IsRecurringFree { get; }

    public IReadOnlyList<string> Aliases { get; }
}

internal sealed class FreeLlmProviderCatalogRuntimeState : IDisposable
{
    private readonly object _lock = new();
    private readonly SemaphoreSlim _refreshLock = new(1, 1);
    private readonly TimeProvider _timeProvider;
    private readonly TimeSpan? _refreshInterval;
    private readonly bool _filterMissingConfiguredModels;
    private readonly bool _routeDiscoveredModels;
    private readonly Func<string, FreeLlmModelDefinition?>? _discoveredModelFactory;

    private DateTimeOffset? _lastRefreshedAt;
    private string? _lastError;
    private HashSet<string>? _latestModelIds;
    private FreeLlmModel[] _discoveredModels = [];

    public FreeLlmProviderCatalogRuntimeState(
        TimeProvider timeProvider,
        TimeSpan? refreshInterval,
        bool filterMissingConfiguredModels,
        bool routeDiscoveredModels,
        Func<string, FreeLlmModelDefinition?>? discoveredModelFactory)
    {
        _timeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
        _refreshInterval = refreshInterval;
        _filterMissingConfiguredModels = filterMissingConfiguredModels;
        _routeDiscoveredModels = routeDiscoveredModels;
        _discoveredModelFactory = discoveredModelFactory;
    }

    public bool ShouldRefresh(DateTimeOffset now)
    {
        if (_refreshInterval is not { } refreshInterval)
        {
            return false;
        }

        lock (_lock)
        {
            return _lastRefreshedAt is null || now >= _lastRefreshedAt.Value + refreshInterval;
        }
    }

    public async Task RefreshAsync(
        Func<CancellationToken, Task<IReadOnlyList<string>>> listModelIdsAsync,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(listModelIdsAsync);

        await _refreshLock.WaitAsync(cancellationToken).ConfigureAwait(false);
        try
        {
            var now = _timeProvider.GetUtcNow();

            try
            {
                var latestModelIds = await listModelIdsAsync(cancellationToken).ConfigureAwait(false);
                var normalizedModelIds = latestModelIds
                    .Where(static modelId => !string.IsNullOrWhiteSpace(modelId))
                    .ToHashSet(StringComparer.OrdinalIgnoreCase);
                var discoveredModels = BuildDiscoveredModels(normalizedModelIds);

                lock (_lock)
                {
                    _latestModelIds = normalizedModelIds;
                    _discoveredModels = discoveredModels;
                    _lastRefreshedAt = now;
                    _lastError = null;
                }
            }
            catch (OperationCanceledException) when (cancellationToken.IsCancellationRequested)
            {
                throw;
            }
#pragma warning disable CA1031
            catch (Exception ex)
#pragma warning restore CA1031
            {
                lock (_lock)
                {
                    _lastRefreshedAt = now;
                    _lastError = ex.Message;
                }
            }
        }
        finally
        {
            _refreshLock.Release();
        }
    }

    public IReadOnlyList<FreeLlmModel> GetRoutingModels(IReadOnlyList<FreeLlmModel> configuredModels)
    {
        ArgumentNullException.ThrowIfNull(configuredModels);

        lock (_lock)
        {
            return GetRoutingModelsUnsafe(configuredModels);
        }
    }

    public FreeLlmProviderCatalog GetSnapshot(string providerId, IReadOnlyList<FreeLlmModel> configuredModels)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(providerId);
        ArgumentNullException.ThrowIfNull(configuredModels);

        lock (_lock)
        {
            var routingModels = GetRoutingModelsUnsafe(configuredModels);
            var routingLookup = routingModels.ToDictionary(static model => model.ModelId, StringComparer.OrdinalIgnoreCase);
            var configuredLookup = configuredModels.ToDictionary(static model => model.ModelId, StringComparer.OrdinalIgnoreCase);
            var discoveredLookup = _discoveredModels.ToDictionary(static model => model.ModelId, StringComparer.OrdinalIgnoreCase);

            var allModelIds = new HashSet<string>(configuredLookup.Keys, StringComparer.OrdinalIgnoreCase);
            if (_latestModelIds is not null)
            {
                allModelIds.UnionWith(_latestModelIds);
            }

            allModelIds.UnionWith(discoveredLookup.Keys);

            var missingConfiguredModelIds = _latestModelIds is null
                ? []
                : configuredModels
                    .Where(model => !_latestModelIds.Contains(model.ModelId))
                    .Select(static model => model.ModelId)
                    .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
                    .ToArray();

            var models = allModelIds
                .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
                .Select(modelId =>
                {
                    var isConfigured = configuredLookup.TryGetValue(modelId, out var configuredModel);
                    var discoveredModel = discoveredLookup.TryGetValue(modelId, out var discoveredCandidate)
                        ? discoveredCandidate
                        : null;
                    var isDiscovered = !isConfigured && discoveredModel is not null;
                    var routingModel = routingLookup.TryGetValue(modelId, out var routableModel)
                        ? routableModel
                        : configuredModel ?? discoveredModel;

                    return new FreeLlmCatalogModel(
                        modelId: modelId,
                        isConfigured: isConfigured,
                        isDiscovered: isDiscovered,
                        isPresentInLatestCatalog: _latestModelIds?.Contains(modelId),
                        isRoutable: routingLookup.ContainsKey(modelId),
                        isRecurringFree: routingModel?.IsRecurringFree == true,
                        aliases: routingModel?.Aliases
                            .OrderBy(static alias => alias, StringComparer.OrdinalIgnoreCase)
                            .ToArray() ?? []);
                })
                .ToArray();

            return new FreeLlmProviderCatalog(
                providerId: providerId,
                refreshedAt: _lastRefreshedAt,
                nextRefreshAt: _lastRefreshedAt is { } refreshedAt && _refreshInterval is { } refreshInterval
                    ? refreshedAt + refreshInterval
                    : null,
                refreshInterval: _refreshInterval,
                filterMissingConfiguredModels: _filterMissingConfiguredModels,
                routeDiscoveredModels: _routeDiscoveredModels,
                lastError: _lastError,
                missingConfiguredModelIds: missingConfiguredModelIds,
                models: models);
        }
    }

    public void Dispose()
    {
        _refreshLock.Dispose();
    }

    private FreeLlmModel[] BuildDiscoveredModels(HashSet<string> latestModelIds)
    {
        if (!_routeDiscoveredModels || _discoveredModelFactory is null || latestModelIds.Count == 0)
        {
            return [];
        }

        var discoveredModels = new List<FreeLlmModel>();
        var seen = new HashSet<string>(StringComparer.OrdinalIgnoreCase);

        foreach (var modelId in latestModelIds.OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase))
        {
            var definition = _discoveredModelFactory(modelId);
            if (definition is null || !seen.Add(definition.ModelId))
            {
                continue;
            }

            discoveredModels.Add(FreeLlmModel.Create(definition));
        }

        return discoveredModels
            .OrderByDescending(static model => model.Priority)
            .ThenBy(static model => model.ModelId, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private FreeLlmModel[] GetRoutingModelsUnsafe(IReadOnlyList<FreeLlmModel> configuredModels)
    {
        IEnumerable<FreeLlmModel> routingModels = configuredModels;

        if (_filterMissingConfiguredModels && _latestModelIds is not null)
        {
            routingModels = routingModels.Where(model => _latestModelIds.Contains(model.ModelId));
        }

        if (_routeDiscoveredModels && _discoveredModels.Length > 0)
        {
            var configuredModelIds = configuredModels
                .Select(static model => model.ModelId)
                .ToHashSet(StringComparer.OrdinalIgnoreCase);
            routingModels = routingModels.Concat(_discoveredModels.Where(model => !configuredModelIds.Contains(model.ModelId)));
        }

        return routingModels.ToArray();
    }
}

internal static class FreeLlmModelCatalogClient
{
    public static async Task<IReadOnlyList<string>> ListOpenAiCompatibleModelsAsync(
        OpenAiClient client,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);

        using var request = new HttpRequestMessage(HttpMethod.Get, BuildProviderUri(client, "models"));
        foreach (var authorization in client.Authorizations)
        {
            if (authorization.Type == "Http" || authorization.Type == "OAuth2")
            {
                request.Headers.Authorization = new AuthenticationHeaderValue(
                    scheme: authorization.Name,
                    parameter: authorization.Value);
            }
            else if (authorization.Type == "ApiKey" && authorization.Location == "Header")
            {
                request.Headers.Add(authorization.Name, authorization.Value);
            }
        }

        using var response = await client.HttpClient.SendAsync(request, cancellationToken).ConfigureAwait(false);
        var content = await response.Content.ReadAsStringAsync(cancellationToken).ConfigureAwait(false);
        response.EnsureSuccessStatusCode();

        return ParseOpenAiCompatibleModelIds(content);
    }

    public static async Task<IReadOnlyList<string>> ListGeminiModelsAsync(
        GeminiClient client,
        CancellationToken cancellationToken)
    {
        ArgumentNullException.ThrowIfNull(client);

        var modelIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        string? pageToken = null;

        do
        {
            cancellationToken.ThrowIfCancellationRequested();
#pragma warning disable CA2016
            var response = await client.ModelsListAsync(pageSize: 100, pageToken: pageToken).ConfigureAwait(false);
#pragma warning restore CA2016
            foreach (var model in response.Models ?? [])
            {
                if (model.BaseModelId is { Length: > 0 } baseModelId)
                {
                    modelIds.Add(baseModelId);
                }

                if (model.Name is { Length: > 0 } name)
                {
                    modelIds.Add(name);
                    if (name.StartsWith("models/", StringComparison.OrdinalIgnoreCase))
                    {
                        modelIds.Add(name["models/".Length..]);
                    }
                }
            }

            pageToken = response.NextPageToken;
        } while (pageToken is { Length: > 0 });

        return modelIds
            .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static string[] ParseOpenAiCompatibleModelIds(string json)
    {
        using var document = JsonDocument.Parse(json);
        var modelIds = new HashSet<string>(StringComparer.OrdinalIgnoreCase);
        CollectOpenAiCompatibleModelIds(document.RootElement, modelIds);

        return modelIds
            .OrderBy(static modelId => modelId, StringComparer.OrdinalIgnoreCase)
            .ToArray();
    }

    private static void CollectOpenAiCompatibleModelIds(JsonElement element, ISet<string> modelIds)
    {
        switch (element.ValueKind)
        {
            case JsonValueKind.Array:
                foreach (var item in element.EnumerateArray())
                {
                    CollectOpenAiCompatibleModelIds(item, modelIds);
                }

                break;

            case JsonValueKind.Object:
                if (TryGetProperty(element, "data", out var dataElement) && dataElement.ValueKind == JsonValueKind.Array)
                {
                    CollectOpenAiCompatibleModelIds(dataElement, modelIds);
                    return;
                }

                if (TryGetProperty(element, "models", out var modelsElement) && modelsElement.ValueKind == JsonValueKind.Array)
                {
                    CollectOpenAiCompatibleModelIds(modelsElement, modelIds);
                    return;
                }

                var preferredId = GetPreferredModelId(element);
                if (!string.IsNullOrWhiteSpace(preferredId))
                {
                    modelIds.Add(preferredId);
                }

                break;
        }
    }

    private static string? GetPreferredModelId(JsonElement element)
    {
        var id = TryGetStringProperty(element, "id");
        var name = TryGetStringProperty(element, "name");

        if (id is { Length: > 0 } && !id.StartsWith("azureml://", StringComparison.OrdinalIgnoreCase))
        {
            return id;
        }

        return name is { Length: > 0 } ? name : id;
    }

    private static string? TryGetStringProperty(JsonElement element, string propertyName)
        => TryGetProperty(element, propertyName, out var property) && property.ValueKind == JsonValueKind.String
            ? property.GetString()
            : null;

    private static bool TryGetProperty(JsonElement element, string propertyName, out JsonElement property)
    {
        foreach (var candidate in element.EnumerateObject())
        {
            if (string.Equals(candidate.Name, propertyName, StringComparison.OrdinalIgnoreCase))
            {
                property = candidate.Value;
                return true;
            }
        }

        property = default;
        return false;
    }

    private static Uri BuildProviderUri(OpenAiClient client, string relativePath)
    {
        var baseAddress = client.HttpClient.BaseAddress
            ?? throw new InvalidOperationException("The provider client does not have a base address configured.");

        var builder = new UriBuilder(baseAddress)
        {
            Path = $"{baseAddress.AbsolutePath.TrimEnd('/')}/{relativePath.TrimStart('/')}",
        };

        return builder.Uri;
    }
}
