using Google.Gemini;
using tryAGI.OpenAI;

namespace FreeLLM;

/// <summary>
/// Fluent builder for creating a free-first routed chat client.
/// </summary>
public sealed class FreeLlmClientBuilder
{
    private readonly List<FreeLlmProviderDefinition> _providers = [];

    public string DefaultAlias { get; private set; } = FreeLlmModelAliases.Smart;

    public TimeProvider TimeProvider { get; private set; } = TimeProvider.System;

    public TimeSpan DefaultRateLimitCooldown { get; private set; } = TimeSpan.FromMinutes(1);

    public TimeSpan DefaultTransientFailureCooldown { get; private set; } = TimeSpan.FromSeconds(30);

    public TimeSpan? DefaultCatalogRefreshInterval { get; private set; }

    public bool FilterMissingConfiguredModels { get; private set; } = true;

    public bool RouteDiscoveredModels { get; private set; }

    public FreeLlmClientBuilder WithDefaultAlias(string alias)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(alias);
        DefaultAlias = alias;
        return this;
    }

    public FreeLlmClientBuilder WithTimeProvider(TimeProvider timeProvider)
    {
        TimeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
        return this;
    }

    public FreeLlmClientBuilder WithDefaultRateLimitCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        DefaultRateLimitCooldown = cooldown;
        return this;
    }

    public FreeLlmClientBuilder WithDefaultTransientFailureCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        DefaultTransientFailureCooldown = cooldown;
        return this;
    }

    public FreeLlmClientBuilder WithCatalogRefresh(
        TimeSpan refreshInterval,
        bool routeDiscoveredModels = false,
        bool filterMissingConfiguredModels = true)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(refreshInterval, TimeSpan.Zero);
        DefaultCatalogRefreshInterval = refreshInterval;
        RouteDiscoveredModels = routeDiscoveredModels;
        FilterMissingConfiguredModels = filterMissingConfiguredModels;
        return this;
    }

    public FreeLlmClientBuilder AddOpenAiCompatibleProvider(
        string providerId,
        OpenAiClient client,
        Action<FreeLlmProviderBuilder>? configure = null,
        bool disposeClient = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(providerId);
        ArgumentNullException.ThrowIfNull(client);

        return AddProvider(
            providerId,
            configure,
            static (definition, state) => new FreeLlmOpenAiProvider(
                providerId: definition.ProviderId,
                priority: definition.Priority,
                client: (OpenAiClient)definition.Client!,
                models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                state: state,
                catalogState: definition.CatalogState!,
                disposeClient: definition.DisposeClient),
            client,
            disposeClient);
    }

    public FreeLlmClientBuilder AddGeminiProvider(
        string providerId,
        GeminiClient client,
        Action<FreeLlmProviderBuilder>? configure = null,
        bool disposeClient = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(providerId);
        ArgumentNullException.ThrowIfNull(client);

        return AddProvider(
            providerId,
            configure,
            static (definition, state) => new FreeLlmGeminiProvider(
                providerId: definition.ProviderId,
                priority: definition.Priority,
                client: (GeminiClient)definition.Client!,
                models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                state: state,
                catalogState: definition.CatalogState!,
                disposeClient: definition.DisposeClient),
            client,
            disposeClient);
    }

    public FreeLlmClientBuilder AddOpenAiCompatible(
        string providerId,
        string apiKey,
        Uri baseUri,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(providerId);
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);
        ArgumentNullException.ThrowIfNull(baseUri);

        return AddProvider(
            providerId,
            configure,
            static (definition, state) =>
            {
                var handler = new FreeLlmResponseTrackingHandler(state, definition.MessageHandler ?? new HttpClientHandler());
                var httpClient = new HttpClient(handler);
                var client = new OpenAiClient(
                    apiKey: definition.ApiKey!,
                    httpClient: httpClient,
                    baseUri: definition.BaseUri,
                    disposeHttpClient: true);
                return new FreeLlmOpenAiProvider(
                    providerId: definition.ProviderId,
                    priority: definition.Priority,
                    client: client,
                    models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                    state: state,
                    catalogState: definition.CatalogState!,
                    disposeClient: true);
            },
            client: null,
            disposeClient: disposeClient,
            apiKey: apiKey,
            baseUri: baseUri,
            messageHandler: messageHandler);
    }

    public FreeLlmClientBuilder AddGemini(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        Uri? baseUri = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(apiKey);

        return AddProvider(
            providerId: "gemini",
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyGeminiDefaults : null,
                configure),
            static (definition, state) =>
            {
                var handler = new FreeLlmResponseTrackingHandler(state, definition.MessageHandler ?? new HttpClientHandler());
                var httpClient = new HttpClient(handler);
                var client = new GeminiClient(
                    apiKey: definition.ApiKey!,
                    httpClient: httpClient,
                    baseUri: definition.BaseUri,
                    disposeHttpClient: true);
                return new FreeLlmGeminiProvider(
                    providerId: definition.ProviderId,
                    priority: definition.Priority,
                    client: client,
                    models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                    state: state,
                    catalogState: definition.CatalogState!,
                    disposeClient: true);
            },
            client: null,
            disposeClient: disposeClient,
            apiKey: apiKey,
            baseUri: baseUri ?? new Uri(GeminiClient.DefaultBaseUrl),
            messageHandler: messageHandler);
    }

    public FreeLlmClientBuilder AddOpenAi(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true)
        => AddOpenAiCompatible("openai", apiKey, new Uri(OpenAiClient.DefaultBaseUrl), configure, messageHandler, disposeClient);

    public FreeLlmClientBuilder AddOpenRouter(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "openrouter",
            apiKey,
            new Uri(CustomProviders.OpenRouterBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyOpenRouterDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddCerebras(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "cerebras",
            apiKey,
            new Uri(CustomProviders.CerebrasBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyCerebrasDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddSambaNova(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "sambanova",
            apiKey,
            new Uri(CustomProviders.SambaNovaBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplySambaNovaDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddGitHubModels(
        string githubToken,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "github-models",
            githubToken,
            new Uri(CustomProviders.GitHubModelsBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyGitHubModelsDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddGroq(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "groq",
            apiKey,
            new Uri(CustomProviders.GroqBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyGroqDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddNvidia(
        string apiKey,
        Action<FreeLlmProviderBuilder>? configure = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true,
        bool useDefaultModels = true)
        => AddOpenAiCompatible(
            "nvidia",
            apiKey,
            new Uri(CustomProviders.NvidiaBaseUrl),
            ComposeProviderConfiguration(
                useDefaultModels ? FreeLlmProviderPresets.ApplyNvidiaDefaults : null,
                configure),
            messageHandler,
            disposeClient);

    public FreeLlmClientBuilder AddOllama(
        Action<FreeLlmProviderBuilder>? configure = null,
        Uri? baseUri = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true)
    {
        return AddProvider(
            providerId: "ollama",
            configure,
            static (definition, state) =>
            {
                var handler = new FreeLlmResponseTrackingHandler(state, definition.MessageHandler ?? new HttpClientHandler());
                var httpClient = new HttpClient(handler);
                var client = new OpenAiClient(
                    httpClient: httpClient,
                    baseUri: definition.BaseUri,
                    options: null,
                    disposeHttpClient: true);
                return new FreeLlmOpenAiProvider(
                    providerId: definition.ProviderId,
                    priority: definition.Priority,
                    client: client,
                    models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                    state: state,
                    catalogState: definition.CatalogState!,
                    disposeClient: true);
            },
            client: null,
            disposeClient: disposeClient,
            apiKey: null,
            baseUri: baseUri ?? new Uri(CustomProviders.OllamaBaseUrl),
            messageHandler: messageHandler);
    }

    public FreeLlmClientBuilder AddLmStudio(
        Action<FreeLlmProviderBuilder>? configure = null,
        Uri? baseUri = null,
        HttpMessageHandler? messageHandler = null,
        bool disposeClient = true)
    {
        return AddProvider(
            providerId: "lmstudio",
            configure,
            static (definition, state) =>
            {
                var handler = new FreeLlmResponseTrackingHandler(state, definition.MessageHandler ?? new HttpClientHandler());
                var httpClient = new HttpClient(handler);
                var client = new OpenAiClient(
                    httpClient: httpClient,
                    baseUri: definition.BaseUri,
                    options: null,
                    disposeHttpClient: true);
                return new FreeLlmOpenAiProvider(
                    providerId: definition.ProviderId,
                    priority: definition.Priority,
                    client: client,
                    models: definition.Models.Select(static model => FreeLlmModel.Create(model)).ToArray(),
                    state: state,
                    catalogState: definition.CatalogState!,
                    disposeClient: true);
            },
            client: null,
            disposeClient: disposeClient,
            apiKey: null,
            baseUri: baseUri ?? new Uri(CustomProviders.LmStudioBaseUrl),
            messageHandler: messageHandler);
    }

    public FreeLlmClient Build()
    {
        if (_providers.Count == 0)
        {
            throw new InvalidOperationException("At least one provider must be registered.");
        }

        var providers = new List<FreeLlmProvider>(_providers.Count);
        foreach (var definition in _providers)
        {
            if (definition.Models.Count == 0)
            {
                throw new InvalidOperationException($"Provider '{definition.ProviderId}' must register at least one model.");
            }

            var state = new FreeLlmProviderRuntimeState(
                timeProvider: TimeProvider,
                rateLimitCooldown: definition.RateLimitCooldown ?? DefaultRateLimitCooldown,
                transientFailureCooldown: definition.TransientFailureCooldown ?? DefaultTransientFailureCooldown);
            var catalogState = new FreeLlmProviderCatalogRuntimeState(
                timeProvider: TimeProvider,
                refreshInterval: definition.CatalogRefreshInterval ?? DefaultCatalogRefreshInterval,
                filterMissingConfiguredModels: definition.FilterMissingConfiguredModels ?? FilterMissingConfiguredModels,
                routeDiscoveredModels: definition.RouteDiscoveredModels ?? RouteDiscoveredModels,
                discoveredModelFactory: definition.DiscoveredModelFactory);
            definition.CatalogState = catalogState;
            providers.Add(definition.ProviderFactory(definition, state));
        }

        return new FreeLlmClient(
            providers: providers,
            defaultAlias: DefaultAlias,
            timeProvider: TimeProvider);
    }

    private FreeLlmClientBuilder AddProvider(
        string providerId,
        Action<FreeLlmProviderBuilder>? configure,
        Func<FreeLlmProviderDefinition, FreeLlmProviderRuntimeState, FreeLlmProvider> providerFactory,
        object? client,
        bool disposeClient,
        string? apiKey = null,
        Uri? baseUri = null,
        HttpMessageHandler? messageHandler = null)
    {
        var definition = new FreeLlmProviderDefinition(providerId, providerFactory)
        {
            Client = client,
            DisposeClient = disposeClient,
            ApiKey = apiKey,
            BaseUri = baseUri,
            MessageHandler = messageHandler,
        };

        var builder = new FreeLlmProviderBuilder(definition);
        configure?.Invoke(builder);
        _providers.Add(definition);
        return this;
    }

    private static Action<FreeLlmProviderBuilder>? ComposeProviderConfiguration(
        Action<FreeLlmProviderBuilder>? defaults,
        Action<FreeLlmProviderBuilder>? configure)
    {
        if (defaults is null)
        {
            return configure;
        }

        if (configure is null)
        {
            return defaults;
        }

        return builder =>
        {
            defaults(builder);
            configure(builder);
        };
    }
}

/// <summary>
/// Fluent builder for a single routed provider registration.
/// </summary>
public sealed class FreeLlmProviderBuilder
{
    private readonly FreeLlmProviderDefinition _definition;

    internal FreeLlmProviderBuilder(FreeLlmProviderDefinition definition)
    {
        _definition = definition;
    }

    public FreeLlmProviderBuilder WithPriority(int priority)
    {
        _definition.Priority = priority;
        return this;
    }

    public FreeLlmProviderBuilder WithRateLimitCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        _definition.RateLimitCooldown = cooldown;
        return this;
    }

    public FreeLlmProviderBuilder WithTransientFailureCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        _definition.TransientFailureCooldown = cooldown;
        return this;
    }

    public FreeLlmProviderBuilder WithCatalogRefresh(
        TimeSpan refreshInterval,
        bool routeDiscoveredModels = false,
        bool filterMissingConfiguredModels = true)
    {
        ArgumentOutOfRangeException.ThrowIfLessThanOrEqual(refreshInterval, TimeSpan.Zero);
        _definition.CatalogRefreshInterval = refreshInterval;
        _definition.RouteDiscoveredModels = routeDiscoveredModels;
        _definition.FilterMissingConfiguredModels = filterMissingConfiguredModels;
        return this;
    }

    public FreeLlmProviderBuilder AddModel(
        string modelId,
        Action<FreeLlmModelBuilder>? configure = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        var definition = _definition.Models.FirstOrDefault(model =>
            string.Equals(model.ModelId, modelId, StringComparison.OrdinalIgnoreCase)) ??
            new FreeLlmModelDefinition(modelId);
        var builder = new FreeLlmModelBuilder(definition);
        configure?.Invoke(builder);
        if (!_definition.Models.Contains(definition))
        {
            _definition.Models.Add(definition);
        }

        return this;
    }

    public FreeLlmProviderBuilder RemoveModel(string modelId)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        _definition.Models.RemoveAll(model =>
            string.Equals(model.ModelId, modelId, StringComparison.OrdinalIgnoreCase));
        return this;
    }

    public FreeLlmProviderBuilder ClearModels()
    {
        _definition.Models.Clear();
        return this;
    }

    internal FreeLlmProviderBuilder WithDiscoveredModelFactory(Func<string, FreeLlmModelDefinition?> discoveredModelFactory)
    {
        _definition.DiscoveredModelFactory = discoveredModelFactory ?? throw new ArgumentNullException(nameof(discoveredModelFactory));
        return this;
    }
}

/// <summary>
/// Fluent builder for a single routed model registration.
/// </summary>
public sealed class FreeLlmModelBuilder
{
    private readonly FreeLlmModelDefinition _definition;

    internal FreeLlmModelBuilder(FreeLlmModelDefinition definition)
    {
        _definition = definition;
    }

    public FreeLlmModelBuilder WithAlias(string alias)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(alias);
        _definition.Aliases.Add(alias);
        return this;
    }

    public FreeLlmModelBuilder WithAlias(string alias, int priority)
    {
        WithAlias(alias);
        _definition.AliasPriorities[alias] = priority;
        return this;
    }

    public FreeLlmModelBuilder WithAliases(params string[] aliases)
    {
        ArgumentNullException.ThrowIfNull(aliases);
        foreach (var alias in aliases)
        {
            WithAlias(alias);
        }

        return this;
    }

    public FreeLlmModelBuilder WithPriority(int priority)
    {
        _definition.Priority = priority;
        return this;
    }

    public FreeLlmModelBuilder IsRecurringFree(bool value = true)
    {
        _definition.IsRecurringFree = value;
        return this;
    }

    public FreeLlmModelBuilder SupportsToolCalls(bool value = true)
    {
        _definition.SupportsToolCalls = value;
        return this;
    }

    public FreeLlmModelBuilder SupportsStructuredOutputs(bool value = true)
    {
        _definition.SupportsStructuredOutputs = value;
        return this;
    }

    public FreeLlmModelBuilder SupportsStreaming(bool value = true)
    {
        _definition.SupportsStreaming = value;
        return this;
    }

    public FreeLlmModelBuilder AsSmart(int priority = 0)
    {
        return WithAlias(FreeLlmModelAliases.Smart, priority);
    }

    public FreeLlmModelBuilder AsSmartAny(int priority = 0)
    {
        return WithAlias(FreeLlmModelAliases.SmartAny, priority);
    }

    public FreeLlmModelBuilder AsFast(int priority = 0)
    {
        return WithAlias(FreeLlmModelAliases.Fast, priority);
    }

    public FreeLlmModelBuilder AsCheap(int priority = 0)
    {
        return WithAlias(FreeLlmModelAliases.Cheap, priority);
    }
}

internal sealed class FreeLlmProviderDefinition
{
    public FreeLlmProviderDefinition(
        string providerId,
        Func<FreeLlmProviderDefinition, FreeLlmProviderRuntimeState, FreeLlmProvider> providerFactory)
    {
        ProviderId = providerId;
        ProviderFactory = providerFactory;
    }

    public string ProviderId { get; }

    public Func<FreeLlmProviderDefinition, FreeLlmProviderRuntimeState, FreeLlmProvider> ProviderFactory { get; }

    public object? Client { get; set; }

    public bool DisposeClient { get; set; }

    public string? ApiKey { get; set; }

    public Uri? BaseUri { get; set; }

    public HttpMessageHandler? MessageHandler { get; set; }

    public int Priority { get; set; }

    public TimeSpan? RateLimitCooldown { get; set; }

    public TimeSpan? TransientFailureCooldown { get; set; }

    public TimeSpan? CatalogRefreshInterval { get; set; }

    public bool? FilterMissingConfiguredModels { get; set; }

    public bool? RouteDiscoveredModels { get; set; }

    public Func<string, FreeLlmModelDefinition?>? DiscoveredModelFactory { get; set; }

    public FreeLlmProviderCatalogRuntimeState? CatalogState { get; set; }

    public List<FreeLlmModelDefinition> Models { get; } = [];
}

internal sealed class FreeLlmModelDefinition
{
    public FreeLlmModelDefinition(string modelId)
    {
        ModelId = modelId;
    }

    public string ModelId { get; }

    public HashSet<string> Aliases { get; } = new(StringComparer.OrdinalIgnoreCase);

    public Dictionary<string, int> AliasPriorities { get; } = new(StringComparer.OrdinalIgnoreCase);

    public int Priority { get; set; }

    public bool IsRecurringFree { get; set; }

    public bool SupportsToolCalls { get; set; } = true;

    public bool SupportsStructuredOutputs { get; set; } = true;

    public bool SupportsStreaming { get; set; } = true;
}
