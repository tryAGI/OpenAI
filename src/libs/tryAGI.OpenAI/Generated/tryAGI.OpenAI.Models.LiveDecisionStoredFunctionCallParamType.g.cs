
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `function_call`.<br/>
    /// Default Value: function_call
    /// </summary>
    public enum LiveDecisionStoredFunctionCallParamType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionStoredFunctionCallParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredFunctionCallParamType value)
        {
            return value switch
            {
                LiveDecisionStoredFunctionCallParamType.FunctionCall => "function_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredFunctionCallParamType? ToEnum(string value)
        {
            return value switch
            {
                "function_call" => LiveDecisionStoredFunctionCallParamType.FunctionCall,
                _ => null,
            };
        }
    }
}