
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `function_call`.<br/>
    /// Default Value: function_call
    /// </summary>
    public enum LiveDecisionFunctionCallParamType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionFunctionCallParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionFunctionCallParamType value)
        {
            return value switch
            {
                LiveDecisionFunctionCallParamType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionFunctionCallParamType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => LiveDecisionFunctionCallParamType.FunctionCall,
                _ => null,
            };
        }
    }
}