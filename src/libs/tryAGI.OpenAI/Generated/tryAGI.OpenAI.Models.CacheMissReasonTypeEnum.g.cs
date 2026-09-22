
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CacheMissReasonTypeEnum
    {
        /// <summary>
        ///
        /// </summary>
        ContextCompacted,
        /// <summary>
        ///
        /// </summary>
        InputChanged,
        /// <summary>
        ///
        /// </summary>
        ModelChanged,
        /// <summary>
        ///
        /// </summary>
        PromptCacheKeyChanged,
        /// <summary>
        ///
        /// </summary>
        ReasoningEffortChanged,
        /// <summary>
        ///
        /// </summary>
        ServiceTierChanged,
        /// <summary>
        ///
        /// </summary>
        TextFormatChanged,
        /// <summary>
        ///
        /// </summary>
        ToolsChanged,
        /// <summary>
        ///
        /// </summary>
        VerbosityChanged,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CacheMissReasonTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CacheMissReasonTypeEnum value)
        {
            return value switch
            {
                CacheMissReasonTypeEnum.ContextCompacted => "context_compacted",
                CacheMissReasonTypeEnum.InputChanged => "input_changed",
                CacheMissReasonTypeEnum.ModelChanged => "model_changed",
                CacheMissReasonTypeEnum.PromptCacheKeyChanged => "prompt_cache_key_changed",
                CacheMissReasonTypeEnum.ReasoningEffortChanged => "reasoning_effort_changed",
                CacheMissReasonTypeEnum.ServiceTierChanged => "service_tier_changed",
                CacheMissReasonTypeEnum.TextFormatChanged => "text_format_changed",
                CacheMissReasonTypeEnum.ToolsChanged => "tools_changed",
                CacheMissReasonTypeEnum.VerbosityChanged => "verbosity_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CacheMissReasonTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "context_compacted" => CacheMissReasonTypeEnum.ContextCompacted,
                "input_changed" => CacheMissReasonTypeEnum.InputChanged,
                "model_changed" => CacheMissReasonTypeEnum.ModelChanged,
                "prompt_cache_key_changed" => CacheMissReasonTypeEnum.PromptCacheKeyChanged,
                "reasoning_effort_changed" => CacheMissReasonTypeEnum.ReasoningEffortChanged,
                "service_tier_changed" => CacheMissReasonTypeEnum.ServiceTierChanged,
                "text_format_changed" => CacheMissReasonTypeEnum.TextFormatChanged,
                "tools_changed" => CacheMissReasonTypeEnum.ToolsChanged,
                "verbosity_changed" => CacheMissReasonTypeEnum.VerbosityChanged,
                _ => null,
            };
        }
    }
}