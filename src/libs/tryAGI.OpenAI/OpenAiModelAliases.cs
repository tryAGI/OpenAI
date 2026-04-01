namespace tryAGI.OpenAI;

/// <summary>
/// Built-in alias names for routed chat models.
/// </summary>
public static class OpenAiModelAliases
{
    /// <summary>
    /// Highest-quality preferred models.
    /// </summary>
    public const string Smart = "smart";

    /// <summary>
    /// Broadest set of high-quality models, including opportunistic fallbacks.
    /// </summary>
    public const string SmartAny = "smart-any";

    /// <summary>
    /// Lowest-latency preferred models.
    /// </summary>
    public const string Fast = "fast";

    /// <summary>
    /// Lowest-cost preferred models.
    /// </summary>
    public const string Cheap = "cheap";
}
