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
            .AddModel("qwen-3-235b-a22b-thinking-2507", model => model
                .WithPriority(220)
                .AsSmart(priority: 220)
                .AsSmartAny(priority: 220)
                .AsFast(priority: 100)
                .IsRecurringFree());
    }

    public static void ApplySambaNovaDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(240)
            .AddModel("DeepSeek-R1", model => model
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
            .AddModel("nvidia/llama-3.1-nemotron-70b-instruct:free", model => model
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
            .AddModel("openai/gpt-4.1", model => model
                .WithPriority(160)
                .AsSmartAny(priority: 160)
                .AsSmart(priority: 150)
                .IsRecurringFree());
    }

    public static void ApplyGroqDefaults(FreeLlmProviderBuilder provider)
    {
        ArgumentNullException.ThrowIfNull(provider);

        provider
            .WithPriority(170)
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
}
