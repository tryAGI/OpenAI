
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredFunctionToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredFunctionToolCallOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => ResponseSteerRequiredInputRequiredFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}