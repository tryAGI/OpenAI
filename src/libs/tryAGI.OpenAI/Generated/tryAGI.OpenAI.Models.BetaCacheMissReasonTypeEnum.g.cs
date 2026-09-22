
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaCacheMissReasonTypeEnum
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
    public static class BetaCacheMissReasonTypeEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCacheMissReasonTypeEnum value)
        {
            return value switch
            {
                BetaCacheMissReasonTypeEnum.ContextCompacted => "context_compacted",
                BetaCacheMissReasonTypeEnum.InputChanged => "input_changed",
                BetaCacheMissReasonTypeEnum.ModelChanged => "model_changed",
                BetaCacheMissReasonTypeEnum.PromptCacheKeyChanged => "prompt_cache_key_changed",
                BetaCacheMissReasonTypeEnum.ReasoningEffortChanged => "reasoning_effort_changed",
                BetaCacheMissReasonTypeEnum.ServiceTierChanged => "service_tier_changed",
                BetaCacheMissReasonTypeEnum.TextFormatChanged => "text_format_changed",
                BetaCacheMissReasonTypeEnum.ToolsChanged => "tools_changed",
                BetaCacheMissReasonTypeEnum.VerbosityChanged => "verbosity_changed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCacheMissReasonTypeEnum? ToEnum(string value)
        {
            return value switch
            {
                "context_compacted" => BetaCacheMissReasonTypeEnum.ContextCompacted,
                "input_changed" => BetaCacheMissReasonTypeEnum.InputChanged,
                "model_changed" => BetaCacheMissReasonTypeEnum.ModelChanged,
                "prompt_cache_key_changed" => BetaCacheMissReasonTypeEnum.PromptCacheKeyChanged,
                "reasoning_effort_changed" => BetaCacheMissReasonTypeEnum.ReasoningEffortChanged,
                "service_tier_changed" => BetaCacheMissReasonTypeEnum.ServiceTierChanged,
                "text_format_changed" => BetaCacheMissReasonTypeEnum.TextFormatChanged,
                "tools_changed" => BetaCacheMissReasonTypeEnum.ToolsChanged,
                "verbosity_changed" => BetaCacheMissReasonTypeEnum.VerbosityChanged,
                _ => null,
            };
        }
    }
}