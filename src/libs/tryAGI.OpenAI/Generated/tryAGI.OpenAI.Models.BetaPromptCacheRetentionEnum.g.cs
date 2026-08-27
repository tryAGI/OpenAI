
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaPromptCacheRetentionEnum
    {
        /// <summary>
        ///
        /// </summary>
        x24h,
        /// <summary>
        ///
        /// </summary>
        InMemory,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaPromptCacheRetentionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaPromptCacheRetentionEnum value)
        {
            return value switch
            {
                BetaPromptCacheRetentionEnum.x24h => "24h",
                BetaPromptCacheRetentionEnum.InMemory => "in_memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaPromptCacheRetentionEnum? ToEnum(string value)
        {
            return value switch
            {
                "24h" => BetaPromptCacheRetentionEnum.x24h,
                "in_memory" => BetaPromptCacheRetentionEnum.InMemory,
                _ => null,
            };
        }
    }
}