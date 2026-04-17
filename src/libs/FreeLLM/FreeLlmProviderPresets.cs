namespace FreeLLM;

/// <summary>
/// Curated default provider/model registrations for common free-first providers.
/// </summary>
public static class FreeLlmProviderPresets
{
    public static void ApplyGeminiDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(300)
            .WithDiscoveredModelFactory(TryCreateGeminiCatalogModel)
            .AddModel("gemini-2.5-flash", model => model
                .WithPriority(170)
                .AsSmart(priority: 170)
                .AsSmartAny(priority: 170)
                .AsFast(priority: 140)
                .AsCheap(priority: 120)
                .IsRecurringFree())
            .AddModel("gemini-2.5-flash-lite", model => model
                .WithPriority(130)
                .AsFast(priority: 180)
                .AsCheap(priority: 180)
                .AsSmartAny(priority: 120)
                .IsRecurringFree());
    }

    public static void ApplyCerebrasDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(260)
            .WithDiscoveredModelFactory(TryCreateCerebrasCatalogModel)
            .AddModel("qwen-3-235b-a22b-instruct-2507", model => model
                .WithPriority(220)
                .AsSmart(priority: 220)
                .AsSmartAny(priority: 220)
                .AsFast(priority: 100)
                .IsRecurringFree())
            .AddModel("llama3.1-8b", model => model
                .WithPriority(120)
                .AsFast(priority: 150)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 90)
                .IsRecurringFree());
    }

    public static void ApplySambaNovaDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(240)
            .WithDiscoveredModelFactory(TryCreateSambaNovaCatalogModel)
            .AddModel("DeepSeek-R1-0528", model => model
                .WithPriority(210)
                .AsSmart(priority: 210)
                .AsSmartAny(priority: 210)
                .IsRecurringFree())
            .AddModel("Meta-Llama-3.3-70B-Instruct", model => model
                .WithPriority(150)
                .AsFast(priority: 150)
                .AsCheap(priority: 110)
                .AsSmartAny(priority: 150)
                .IsRecurringFree())
            .AddModel("Qwen3-32B", model => model
                .WithPriority(110)
                .AsFast(priority: 130)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 110)
                .IsRecurringFree());
    }

    public static void ApplyOpenRouterDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(100)
            .WithDiscoveredModelFactory(TryCreateOpenRouterCatalogModel)
            .AddModel("openrouter/free", model => model
                .WithPriority(120)
                .AsCheap(priority: 220)
                .AsFast(priority: 120)
                .AsSmartAny(priority: 120)
                .IsRecurringFree())
            .AddModel("meta-llama/llama-3.3-70b-instruct:free", model => model
                .WithPriority(140)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 150)
                .IsRecurringFree())
            .AddModel("meta-llama/llama-3.2-3b-instruct:free", model => model
                .WithPriority(130)
                .AsFast(priority: 140)
                .AsSmartAny(priority: 140)
                .IsRecurringFree());
    }

    public static void ApplyGitHubModelsDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(180)
            .WithDiscoveredModelFactory(TryCreateGitHubModelsCatalogModel)
            .AddModel("gpt-4o", model => model
                .WithPriority(170)
                .AsSmartAny(priority: 170)
                .AsSmart(priority: 160)
                .IsRecurringFree())
            .AddModel("gpt-4o-mini", model => model
                .WithPriority(130)
                .AsFast(priority: 180)
                .AsCheap(priority: 180)
                .AsSmartAny(priority: 120)
                .IsRecurringFree());
    }

    public static void ApplyGroqDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(170)
            .WithDiscoveredModelFactory(TryCreateGroqCatalogModel)
            .AddModel("openai/gpt-oss-120b", model => model
                .WithPriority(170)
                .AsSmartAny(priority: 190)
                .AsSmart(priority: 180))
            .AddModel("llama-3.3-70b-versatile", model => model
                .WithPriority(150)
                .AsFast(priority: 170)
                .AsCheap(priority: 120)
                .AsSmartAny(priority: 150))
            .AddModel("openai/gpt-oss-20b", model => model
                .WithPriority(130)
                .AsFast(priority: 150)
                .AsCheap(priority: 160)
                .AsSmartAny(priority: 120));
    }

    public static void ApplyNvidiaDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(160)
            .WithDiscoveredModelFactory(TryCreateNvidiaCatalogModel)
            .AddModel("openai/gpt-oss-20b", model => model
                .WithPriority(140)
                .AsFast(priority: 150)
                .AsCheap(priority: 150)
                .AsSmartAny(priority: 150))
            .AddModel("meta/llama-3.2-3b-instruct", model => model
                .WithPriority(100)
                .AsFast(priority: 170)
                .AsCheap(priority: 180));
    }

    private static FreeLlmModelDefinition? TryCreateGeminiCatalogModel(string modelId)
    {
        if (!modelId.StartsWith("gemini-", StringComparison.OrdinalIgnoreCase))
        {
            return null;
        }

        if (ContainsAny(modelId, "embedding", "image", "tts", "audio", "computer-use", "veo", "imagen", "lyria", "aqa", "robotics"))
        {
            return null;
        }

        if (modelId.Contains("flash-lite", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(130)
                .AsFast(priority: 210)
                .AsCheap(priority: 220)
                .AsSmartAny(priority: 120)
                .IsRecurringFree());
        }

        if (modelId.Contains("flash", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(170)
                .AsSmart(priority: 170)
                .AsSmartAny(priority: 180)
                .AsFast(priority: 170)
                .AsCheap(priority: 140)
                .IsRecurringFree());
        }

        if (modelId.Contains("pro", StringComparison.OrdinalIgnoreCase))
        {
            var isRecurringFree = modelId.Contains("2.5-pro", StringComparison.OrdinalIgnoreCase);
            return CreateModel(modelId, model => model
                .WithPriority(240)
                .AsSmart(priority: 260)
                .AsSmartAny(priority: 270)
                .IsRecurringFree(isRecurringFree));
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateCerebrasCatalogModel(string modelId)
    {
        if (ContainsAny(modelId, "235b", "120b", "thinking"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(220)
                .AsSmart(priority: 220)
                .AsSmartAny(priority: 220)
                .AsFast(priority: 100)
                .IsRecurringFree());
        }

        if (ContainsAny(modelId, "20b", "8b"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(120)
                .AsFast(priority: 150)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 90)
                .IsRecurringFree());
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateSambaNovaCatalogModel(string modelId)
    {
        if (ContainsAny(modelId, "DeepSeek-R1", "DeepSeek-V3", "Qwen3-235B", "gpt-oss-120b", "MiniMax-M2.5"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(210)
                .AsSmart(priority: 210)
                .AsSmartAny(priority: 220)
                .IsRecurringFree());
        }

        if (modelId.Contains("Meta-Llama-3.3-70B-Instruct", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(150)
                .AsFast(priority: 150)
                .AsCheap(priority: 110)
                .AsSmartAny(priority: 150)
                .IsRecurringFree());
        }

        if (modelId.Contains("Qwen3-32B", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(110)
                .AsFast(priority: 130)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 110)
                .IsRecurringFree());
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateGitHubModelsCatalogModel(string modelId)
    {
        if (ContainsAny(modelId, "embed"))
        {
            return null;
        }

        if (modelId.StartsWith("gpt-5", StringComparison.OrdinalIgnoreCase) ||
            modelId.StartsWith("o3", StringComparison.OrdinalIgnoreCase) ||
            modelId.StartsWith("o4", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(250)
                .AsSmart(priority: 260)
                .AsSmartAny(priority: 270));
        }

        if (string.Equals(modelId, "gpt-4o", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(modelId, "gpt-4.1", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(170)
                .AsSmart(priority: 170)
                .AsSmartAny(priority: 180)
                .IsRecurringFree());
        }

        if (string.Equals(modelId, "gpt-4o-mini", StringComparison.OrdinalIgnoreCase) ||
            string.Equals(modelId, "gpt-4.1-mini", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(130)
                .AsFast(priority: 180)
                .AsCheap(priority: 180)
                .AsSmartAny(priority: 120)
                .IsRecurringFree());
        }

        if (modelId.Contains("405B", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(150)
                .AsSmartAny(priority: 160));
        }

        if (modelId.Contains("8B", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(90)
                .AsFast(priority: 120)
                .AsCheap(priority: 140));
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateGroqCatalogModel(string modelId)
    {
        if (ContainsAny(modelId, "gpt-oss-120b", "kimi-k2", "groq/compound"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(180)
                .AsSmart(priority: 180)
                .AsSmartAny(priority: 190));
        }

        if (ContainsAny(modelId, "llama-3.3-70b-versatile", "qwen/qwen3-32b"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(150)
                .AsFast(priority: 170)
                .AsCheap(priority: 120)
                .AsSmartAny(priority: 150));
        }

        if (ContainsAny(modelId, "gpt-oss-20b", "llama-3.1-8b-instant"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(130)
                .AsFast(priority: 150)
                .AsCheap(priority: 160)
                .AsSmartAny(priority: 120));
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateOpenRouterCatalogModel(string modelId)
    {
        if (string.Equals(modelId, "openrouter/free", StringComparison.OrdinalIgnoreCase))
        {
            return CreateModel(modelId, model => model
                .WithPriority(120)
                .AsCheap(priority: 220)
                .AsFast(priority: 120)
                .AsSmartAny(priority: 120)
                .IsRecurringFree());
        }

        if (modelId.EndsWith(":free", StringComparison.OrdinalIgnoreCase))
        {
            if (ContainsAny(modelId, "llama-3.3-70b-instruct:free", "gpt-oss-120b:free", "qwen3-next-80b-a3b-instruct:free", "qwen3-coder:free"))
            {
                return CreateModel(modelId, model => model
                    .WithPriority(160)
                    .AsSmartAny(priority: 190)
                    .AsFast(priority: 140)
                    .AsCheap(priority: 170)
                    .IsRecurringFree());
            }

            if (ContainsAny(modelId, "3b-instruct:free", "nano", "mini"))
            {
                return CreateModel(modelId, model => model
                    .WithPriority(110)
                    .AsFast(priority: 150)
                    .AsCheap(priority: 190)
                    .IsRecurringFree());
            }

            return null;
        }

        if (ContainsAny(modelId, "gpt-5.4", "claude-opus-4.6", "gemini-3.1-pro", "grok-4.20", "grok-4-fast", "grok-4"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(290)
                .AsSmart(priority: 300)
                .AsSmartAny(priority: 300));
        }

        if (ContainsAny(modelId, "gpt-5", "claude-opus", "claude-sonnet-4.6", "gemini-2.5-pro", "gemini-3-pro", "o3", "o4"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(250)
                .AsSmart(priority: 260)
                .AsSmartAny(priority: 270));
        }

        return null;
    }

    private static FreeLlmModelDefinition? TryCreateNvidiaCatalogModel(string modelId)
    {
        if (ContainsAny(modelId, "gpt-oss-120b", "mistral-large", "kimi-k2", "glm-4.7", "deepseek-v3.1"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(180)
                .AsSmart(priority: 180)
                .AsSmartAny(priority: 190));
        }

        if (ContainsAny(modelId, "gpt-oss-20b", "llama-3.2-3b-instruct"))
        {
            return CreateModel(modelId, model => model
                .WithPriority(140)
                .AsFast(priority: 160)
                .AsCheap(priority: 170)
                .AsSmartAny(priority: 140));
        }

        return null;
    }

    private static FreeLlmModelDefinition CreateModel(string modelId, Action<FreeLlmModelBuilder> configure)
    {
        var definition = new FreeLlmModelDefinition(modelId);
        configure(new FreeLlmModelBuilder(definition));
        return definition;
    }

    private static bool ContainsAny(string value, params string[] candidates)
        => candidates.Any(candidate => value.Contains(candidate, StringComparison.OrdinalIgnoreCase));
}
