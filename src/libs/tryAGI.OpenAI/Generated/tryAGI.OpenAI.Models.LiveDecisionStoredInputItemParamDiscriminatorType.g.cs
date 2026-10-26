
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredInputItemParamDiscriminatorType
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
    public static class LiveDecisionStoredInputItemParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredInputItemParamDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCall => "custom_tool_call",
                LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCall => "function_call",
                LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCallOutput => "function_call_output",
                LiveDecisionStoredInputItemParamDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredInputItemParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => LiveDecisionStoredInputItemParamDiscriminatorType.CustomToolCallOutput,
                "function_call" => LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCall,
                "function_call_output" => LiveDecisionStoredInputItemParamDiscriminatorType.FunctionCallOutput,
                "message" => LiveDecisionStoredInputItemParamDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}