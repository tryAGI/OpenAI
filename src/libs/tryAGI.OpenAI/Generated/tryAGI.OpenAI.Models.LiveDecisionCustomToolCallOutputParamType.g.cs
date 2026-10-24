
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: custom_tool_call_output
    /// </summary>
    public enum LiveDecisionCustomToolCallOutputParamType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionCustomToolCallOutputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionCustomToolCallOutputParamType value)
        {
            return value switch
            {
                LiveDecisionCustomToolCallOutputParamType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionCustomToolCallOutputParamType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => LiveDecisionCustomToolCallOutputParamType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}