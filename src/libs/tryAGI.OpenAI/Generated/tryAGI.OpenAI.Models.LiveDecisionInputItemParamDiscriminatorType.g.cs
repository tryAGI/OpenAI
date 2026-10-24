
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionInputItemParamDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCall,
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionInputItemParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionInputItemParamDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionInputItemParamDiscriminatorType.CustomToolCall => "custom_tool_call",
                LiveDecisionInputItemParamDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                LiveDecisionInputItemParamDiscriminatorType.FunctionCall => "function_call",
                LiveDecisionInputItemParamDiscriminatorType.FunctionCallOutput => "function_call_output",
                LiveDecisionInputItemParamDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionInputItemParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => LiveDecisionInputItemParamDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => LiveDecisionInputItemParamDiscriminatorType.CustomToolCallOutput,
                "function_call" => LiveDecisionInputItemParamDiscriminatorType.FunctionCall,
                "function_call_output" => LiveDecisionInputItemParamDiscriminatorType.FunctionCallOutput,
                "message" => LiveDecisionInputItemParamDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}