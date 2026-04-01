using Meai = Microsoft.Extensions.AI;

namespace tryAGI.OpenAI;

/// <summary>
/// Fluent builder for creating an alias-aware routed <see cref="Meai.IChatClient"/>.
/// </summary>
public sealed class OpenAiRoutedChatClientBuilder
{
    private readonly List<OpenAiRoutedProviderDefinition> _providers = [];

    /// <summary>
    /// Gets the default alias used when no model id is specified.
    /// </summary>
    public string DefaultAlias { get; private set; } = OpenAiModelAliases.Smart;

    /// <summary>
    /// Gets the time provider used for cooldown calculations.
    /// </summary>
    public TimeProvider TimeProvider { get; private set; } = TimeProvider.System;

    /// <summary>
    /// Gets the fallback cooldown used when a provider returns 429 without a usable reset header.
    /// </summary>
    public TimeSpan DefaultRateLimitCooldown { get; private set; } = TimeSpan.FromMinutes(1);

    /// <summary>
    /// Gets the fallback cooldown used for transient failures.
    /// </summary>
    public TimeSpan DefaultTransientFailureCooldown { get; private set; } = TimeSpan.FromSeconds(30);

    /// <summary>
    /// Sets the default alias used when no model id is specified.
    /// </summary>
    public OpenAiRoutedChatClientBuilder WithDefaultAlias(string alias)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(alias);
        DefaultAlias = alias;
        return this;
    }

    /// <summary>
    /// Sets the time provider used for cooldown calculations.
    /// </summary>
    public OpenAiRoutedChatClientBuilder WithTimeProvider(TimeProvider timeProvider)
    {
        TimeProvider = timeProvider ?? throw new ArgumentNullException(nameof(timeProvider));
        return this;
    }

    /// <summary>
    /// Sets the fallback cooldown used when a provider returns 429 without a usable reset header.
    /// </summary>
    public OpenAiRoutedChatClientBuilder WithDefaultRateLimitCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        DefaultRateLimitCooldown = cooldown;
        return this;
    }

    /// <summary>
    /// Sets the fallback cooldown used for transient failures.
    /// </summary>
    public OpenAiRoutedChatClientBuilder WithDefaultTransientFailureCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        DefaultTransientFailureCooldown = cooldown;
        return this;
    }

    /// <summary>
    /// Registers an <see cref="OpenAiClient"/> to participate in routing.
    /// </summary>
    /// <param name="providerId">A stable provider id, for example <c>cerebras</c> or <c>openrouter</c>.</param>
    /// <param name="client">The configured provider client.</param>
    /// <param name="configure">Model registrations and provider-specific settings.</param>
    /// <param name="disposeClient">Whether the built routed client should dispose the supplied client.</param>
    public OpenAiRoutedChatClientBuilder AddProvider(
        string providerId,
        OpenAiClient client,
        Action<OpenAiRoutedProviderBuilder>? configure,
        bool disposeClient = false)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(providerId);
        ArgumentNullException.ThrowIfNull(client);

        var definition = new OpenAiRoutedProviderDefinition(providerId, client, disposeClient);
        var builder = new OpenAiRoutedProviderBuilder(definition);
        configure?.Invoke(builder);
        _providers.Add(definition);
        return this;
    }

    /// <summary>
    /// Registers an <see cref="OpenAiClient"/> to participate in routing.
    /// </summary>
    public OpenAiRoutedChatClientBuilder AddProvider(
        string providerId,
        OpenAiClient client,
        bool disposeClient = false)
        => AddProvider(providerId, client, configure: null, disposeClient: disposeClient);

    /// <summary>
    /// Builds the routed chat client.
    /// </summary>
    public OpenAiRoutedChatClient Build()
    {
        if (_providers.Count == 0)
        {
            throw new InvalidOperationException("At least one provider must be registered.");
        }

        var finalizedProviders = new List<OpenAiRoutedProvider>(_providers.Count);
        foreach (var provider in _providers)
        {
            if (provider.Models.Count == 0)
            {
                throw new InvalidOperationException($"Provider '{provider.ProviderId}' must register at least one model.");
            }

            finalizedProviders.Add(OpenAiRoutedProvider.Create(
                provider,
                timeProvider: TimeProvider,
                defaultRateLimitCooldown: DefaultRateLimitCooldown,
                defaultTransientFailureCooldown: DefaultTransientFailureCooldown));
        }

        return new OpenAiRoutedChatClient(
            providers: finalizedProviders,
            defaultAlias: DefaultAlias,
            timeProvider: TimeProvider);
    }
}

/// <summary>
/// Fluent builder for a single routed provider registration.
/// </summary>
public sealed class OpenAiRoutedProviderBuilder
{
    private readonly OpenAiRoutedProviderDefinition _definition;

    internal OpenAiRoutedProviderBuilder(OpenAiRoutedProviderDefinition definition)
    {
        _definition = definition;
    }

    /// <summary>
    /// Sets the provider-specific cooldown used when a provider returns 429 without a usable reset header.
    /// </summary>
    public OpenAiRoutedProviderBuilder WithRateLimitCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        _definition.RateLimitCooldown = cooldown;
        return this;
    }

    /// <summary>
    /// Sets the provider-specific cooldown used for transient failures.
    /// </summary>
    public OpenAiRoutedProviderBuilder WithTransientFailureCooldown(TimeSpan cooldown)
    {
        ArgumentOutOfRangeException.ThrowIfLessThan(cooldown, TimeSpan.Zero);
        _definition.TransientFailureCooldown = cooldown;
        return this;
    }

    /// <summary>
    /// Adds a model registration for this provider.
    /// </summary>
    public OpenAiRoutedProviderBuilder AddModel(
        string modelId,
        Action<OpenAiRoutedModelBuilder>? configure = null)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(modelId);

        var definition = new OpenAiRoutedModelDefinition(modelId);
        var builder = new OpenAiRoutedModelBuilder(definition);
        configure?.Invoke(builder);
        _definition.Models.Add(definition);
        return this;
    }
}

/// <summary>
/// Fluent builder for a single routed model registration.
/// </summary>
public sealed class OpenAiRoutedModelBuilder
{
    private readonly OpenAiRoutedModelDefinition _definition;

    internal OpenAiRoutedModelBuilder(OpenAiRoutedModelDefinition definition)
    {
        _definition = definition;
    }

    /// <summary>
    /// Adds a custom alias for this model.
    /// </summary>
    public OpenAiRoutedModelBuilder WithAlias(string alias)
    {
        ArgumentException.ThrowIfNullOrWhiteSpace(alias);
        _definition.Aliases.Add(alias);
        return this;
    }

    /// <summary>
    /// Adds custom aliases for this model.
    /// </summary>
    public OpenAiRoutedModelBuilder WithAliases(params string[] aliases)
    {
        ArgumentNullException.ThrowIfNull(aliases);
        foreach (var alias in aliases)
        {
            WithAlias(alias);
        }

        return this;
    }

    /// <summary>
    /// Sets the route priority for this model. Higher values are preferred.
    /// </summary>
    public OpenAiRoutedModelBuilder WithPriority(int priority)
    {
        _definition.Priority = priority;
        return this;
    }

    /// <summary>
    /// Marks whether this model participates in the recurring free pool.
    /// </summary>
    public OpenAiRoutedModelBuilder IsRecurringFree(bool value = true)
    {
        _definition.IsRecurringFree = value;
        return this;
    }

    /// <summary>
    /// Marks whether this model supports tool calling.
    /// </summary>
    public OpenAiRoutedModelBuilder SupportsToolCalls(bool value = true)
    {
        _definition.SupportsToolCalls = value;
        return this;
    }

    /// <summary>
    /// Marks whether this model supports structured outputs / JSON schema responses.
    /// </summary>
    public OpenAiRoutedModelBuilder SupportsStructuredOutputs(bool value = true)
    {
        _definition.SupportsStructuredOutputs = value;
        return this;
    }

    /// <summary>
    /// Marks whether this model supports streaming.
    /// </summary>
    public OpenAiRoutedModelBuilder SupportsStreaming(bool value = true)
    {
        _definition.SupportsStreaming = value;
        return this;
    }

    /// <summary>
    /// Adds the <see cref="OpenAiModelAliases.Smart"/> alias.
    /// </summary>
    public OpenAiRoutedModelBuilder AsSmart(int priority = 0)
    {
        _definition.Priority = priority;
        _definition.Aliases.Add(OpenAiModelAliases.Smart);
        return this;
    }

    /// <summary>
    /// Adds the <see cref="OpenAiModelAliases.SmartAny"/> alias.
    /// </summary>
    public OpenAiRoutedModelBuilder AsSmartAny(int priority = 0)
    {
        _definition.Priority = priority;
        _definition.Aliases.Add(OpenAiModelAliases.SmartAny);
        return this;
    }

    /// <summary>
    /// Adds the <see cref="OpenAiModelAliases.Fast"/> alias.
    /// </summary>
    public OpenAiRoutedModelBuilder AsFast(int priority = 0)
    {
        _definition.Priority = priority;
        _definition.Aliases.Add(OpenAiModelAliases.Fast);
        return this;
    }

    /// <summary>
    /// Adds the <see cref="OpenAiModelAliases.Cheap"/> alias.
    /// </summary>
    public OpenAiRoutedModelBuilder AsCheap(int priority = 0)
    {
        _definition.Priority = priority;
        _definition.Aliases.Add(OpenAiModelAliases.Cheap);
        return this;
    }
}

internal sealed class OpenAiRoutedProviderDefinition
{
    public OpenAiRoutedProviderDefinition(string providerId, OpenAiClient client, bool disposeClient)
    {
        ProviderId = providerId;
        Client = client;
        DisposeClient = disposeClient;
    }

    public string ProviderId { get; }
    public OpenAiClient Client { get; }
    public bool DisposeClient { get; }
    public List<OpenAiRoutedModelDefinition> Models { get; } = [];
    public TimeSpan? RateLimitCooldown { get; set; }
    public TimeSpan? TransientFailureCooldown { get; set; }
}

internal sealed class OpenAiRoutedModelDefinition
{
    public OpenAiRoutedModelDefinition(string modelId)
    {
        ModelId = modelId;
    }

    public string ModelId { get; }
    public HashSet<string> Aliases { get; } = new(StringComparer.OrdinalIgnoreCase);
    public int Priority { get; set; }
    public bool IsRecurringFree { get; set; }
    public bool SupportsToolCalls { get; set; } = true;
    public bool SupportsStructuredOutputs { get; set; } = true;
    public bool SupportsStreaming { get; set; } = true;
}
