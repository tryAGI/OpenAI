
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerInputItemDiscriminatorType
    {
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
    public static class BetaResponseSteerInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerInputItemDiscriminatorType value)
        {
            return value switch
            {
                BetaResponseSteerInputItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                BetaResponseSteerInputItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => BetaResponseSteerInputItemDiscriminatorType.FunctionCallOutput,
                "message" => BetaResponseSteerInputItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}