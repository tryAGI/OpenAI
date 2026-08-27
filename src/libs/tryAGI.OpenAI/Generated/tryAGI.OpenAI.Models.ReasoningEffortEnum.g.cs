
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
    public enum ReasoningEffortEnum
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
    public static class ReasoningEffortEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningEffortEnum value)
        {
            return value switch
            {
                ReasoningEffortEnum.High => "high",
                ReasoningEffortEnum.Low => "low",
                ReasoningEffortEnum.Max => "max",
                ReasoningEffortEnum.Medium => "medium",
                ReasoningEffortEnum.Minimal => "minimal",
                ReasoningEffortEnum.None => "none",
                ReasoningEffortEnum.Xhigh => "xhigh",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningEffortEnum? ToEnum(string value)
        {
            return value switch
            {
                "high" => ReasoningEffortEnum.High,
                "low" => ReasoningEffortEnum.Low,
                "max" => ReasoningEffortEnum.Max,
                "medium" => ReasoningEffortEnum.Medium,
                "minimal" => ReasoningEffortEnum.Minimal,
                "none" => ReasoningEffortEnum.None,
                "xhigh" => ReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}