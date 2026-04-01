namespace FreeLLM;

/// <summary>
/// Shared model aliases for free-first routing.
/// </summary>
public static class FreeLlmModelAliases
{
    /// <summary>
    /// Highest quality recurring-free route, with fallback to <see cref="SmartAny"/>.
    /// </summary>
    public const string Smart = "smart";

    /// <summary>
    /// Highest quality route regardless of recurring-free status.
    /// </summary>
    public const string SmartAny = "smart-any";

    /// <summary>
    /// Lowest-latency route.
    /// </summary>
    public const string Fast = "fast";

    /// <summary>
    /// Lowest-cost route.
    /// </summary>
    public const string Cheap = "cheap";
}
