
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The retention policy for the prompt cache. Set to `24h` to enable extended prompt caching, which keeps cached prefixes active for longer, up to a maximum of 24 hours. [Learn more](/docs/guides/prompt-caching#prompt-cache-retention).
    /// </summary>
    public enum ModelResponsePropertiesPromptCacheRetention2
    {
        /// <summary>
        /// 
        /// </summary>
        InMemory,
        /// <summary>
        /// 
        /// </summary>
        x24h,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ModelResponsePropertiesPromptCacheRetention2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelResponsePropertiesPromptCacheRetention2 value)
        {
            return value switch
            {
                ModelResponsePropertiesPromptCacheRetention2.InMemory => "in-memory",
                ModelResponsePropertiesPromptCacheRetention2.x24h => "24h",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelResponsePropertiesPromptCacheRetention2? ToEnum(string value)
        {
            return value switch
            {
                "in-memory" => ModelResponsePropertiesPromptCacheRetention2.InMemory,
                "24h" => ModelResponsePropertiesPromptCacheRetention2.x24h,
                _ => null,
            };
        }
    }
}