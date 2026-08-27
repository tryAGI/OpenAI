
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains effort on reasoning for reasoning models. Currently supported<br/>
    /// values are `none`, `minimal`, `low`, `medium`, `high`, `xhigh`, and `max`.<br/>
    /// Reducing reasoning effort can result in faster responses and fewer tokens<br/>
    /// used on reasoning in a response. Not all reasoning models support every<br/>
    /// value. See the<br/>
    /// [reasoning guide](https://platform.openai.com/docs/guides/reasoning)<br/>
    /// for model-specific support.<br/>
    /// Default Value: medium
    /// </summary>
    public enum BetaReasoningEffortEnum
    {
        /// <summary>
        ///
        /// </summary>
        High,
        /// <summary>
        ///
        /// </summary>
        Low,
        /// <summary>
        ///
        /// </summary>
        Max,
        /// <summary>
        ///
        /// </summary>
        Medium,
        /// <summary>
        ///
        /// </summary>
        Minimal,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Xhigh,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningEffortEnum value)
        {
            return value switch
            {
                BetaReasoningEffortEnum.High => "high",
                BetaReasoningEffortEnum.Low => "low",
                BetaReasoningEffortEnum.Max => "max",
                BetaReasoningEffortEnum.Medium => "medium",
                BetaReasoningEffortEnum.Minimal => "minimal",
                BetaReasoningEffortEnum.None => "none",
                BetaReasoningEffortEnum.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => BetaReasoningEffortEnum.High,
                "low" => BetaReasoningEffortEnum.Low,
                "max" => BetaReasoningEffortEnum.Max,
                "medium" => BetaReasoningEffortEnum.Medium,
                "minimal" => BetaReasoningEffortEnum.Minimal,
                "none" => BetaReasoningEffortEnum.None,
                "xhigh" => BetaReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}