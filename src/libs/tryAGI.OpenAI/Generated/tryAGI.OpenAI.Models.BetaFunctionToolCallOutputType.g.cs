
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the function tool call output. Always `function_call_output`.
    /// </summary>
    public enum BetaFunctionToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaFunctionToolCallOutputType value)
        {
            return value switch
            {
                BetaFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => BetaFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}