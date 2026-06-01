
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The retention policy for the prompt cache. Set to `24h` to enable extended prompt caching, which keeps cached prefixes active for longer, up to a maximum of 24 hours. [Learn more](/docs/guides/prompt-caching#prompt-cache-retention).<br/>
    /// For `gpt-5.5`, `gpt-5.5-pro`, and future models, only `24h` is supported.<br/>
    /// For older models that support both `in_memory` and `24h`, the default depends on your organization's data retention policy:<br/>
    ///   - Organizations without ZDR enabled default to `24h`.<br/>
    ///   - Organizations with ZDR enabled default to `in_memory` when `prompt_cache_retention` is not specified.
    /// </summary>
    public enum ModelResponsePropertiesPromptCacheRetention2
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
    public static class ModelResponsePropertiesPromptCacheRetention2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelResponsePropertiesPromptCacheRetention2 value)
        {
            return value switch
            {
                ModelResponsePropertiesPromptCacheRetention2.x24h => "24h",
                ModelResponsePropertiesPromptCacheRetention2.InMemory => "in_memory",
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
                "24h" => ModelResponsePropertiesPromptCacheRetention2.x24h,
                "in_memory" => ModelResponsePropertiesPromptCacheRetention2.InMemory,
                _ => null,
            };
        }
    }
}