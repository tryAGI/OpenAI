
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputVariant2ItemDiscriminatorType
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
    public static class DecisionInputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                DecisionInputVariant2ItemDiscriminatorType.CustomToolCall => "custom_tool_call",
                DecisionInputVariant2ItemDiscriminatorType.CustomToolCallOutput => "custom_tool_call_output",
                DecisionInputVariant2ItemDiscriminatorType.FunctionCall => "function_call",
                DecisionInputVariant2ItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                DecisionInputVariant2ItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call" => DecisionInputVariant2ItemDiscriminatorType.CustomToolCall,
                "custom_tool_call_output" => DecisionInputVariant2ItemDiscriminatorType.CustomToolCallOutput,
                "function_call" => DecisionInputVariant2ItemDiscriminatorType.FunctionCall,
                "function_call_output" => DecisionInputVariant2ItemDiscriminatorType.FunctionCallOutput,
                "message" => DecisionInputVariant2ItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}