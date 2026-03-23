
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Constrains effort on reasoning for<br/>
    /// [reasoning models](https://platform.openai.com/docs/guides/reasoning).<br/>
    /// Currently supported values are `none`, `minimal`, `low`, `medium`, `high`, and `xhigh`. Reducing<br/>
    /// reasoning effort can result in faster responses and fewer tokens used<br/>
    /// on reasoning in a response.<br/>
    /// - `gpt-5.1` defaults to `none`, which does not perform reasoning. The supported reasoning values for `gpt-5.1` are `none`, `low`, `medium`, and `high`. Tool calls are supported for all reasoning values in gpt-5.1.<br/>
    /// - All models before `gpt-5.1` default to `medium` reasoning effort, and do not support `none`.<br/>
    /// - The `gpt-5-pro` model defaults to (and only supports) `high` reasoning effort.<br/>
    /// - `xhigh` is supported for all models after `gpt-5.1-codex-max`.<br/>
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
                "medium" => ReasoningEffortEnum.Medium,
                "minimal" => ReasoningEffortEnum.Minimal,
                "none" => ReasoningEffortEnum.None,
                "xhigh" => ReasoningEffortEnum.Xhigh,
                _ => null,
            };
        }
    }
}