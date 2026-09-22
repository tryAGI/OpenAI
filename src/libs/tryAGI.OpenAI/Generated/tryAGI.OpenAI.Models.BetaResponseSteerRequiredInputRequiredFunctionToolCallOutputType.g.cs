
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        FunctionCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType.FunctionCallOutput => "function_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => BetaResponseSteerRequiredInputRequiredFunctionToolCallOutputType.FunctionCallOutput,
                _ => null,
            };
        }
    }
}