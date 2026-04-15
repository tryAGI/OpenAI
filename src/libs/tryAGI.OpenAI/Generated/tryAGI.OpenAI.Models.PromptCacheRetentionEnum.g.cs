
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum PromptCacheRetentionEnum
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
    public static class PromptCacheRetentionEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PromptCacheRetentionEnum value)
        {
            return value switch
            {
                PromptCacheRetentionEnum.x24h => "24h",
                PromptCacheRetentionEnum.InMemory => "in_memory",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PromptCacheRetentionEnum? ToEnum(string value)
        {
            return value switch
            {
                "24h" => PromptCacheRetentionEnum.x24h,
                "in_memory" => PromptCacheRetentionEnum.InMemory,
                _ => null,
            };
        }
    }
}