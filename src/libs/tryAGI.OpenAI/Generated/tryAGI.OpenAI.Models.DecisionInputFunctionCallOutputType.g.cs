
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: function_call_output
    /// </summary>
    public enum DecisionInputFunctionCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputFunctionCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputFunctionCallOutputType value)
        {
            return value switch
            {
                DecisionInputFunctionCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputFunctionCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => DecisionInputFunctionCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}