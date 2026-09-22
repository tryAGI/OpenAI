
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerInputItemDiscriminatorType
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
    public static class ResponseSteerInputItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerInputItemDiscriminatorType value)
        {
            return value switch
            {
                ResponseSteerInputItemDiscriminatorType.FunctionCallOutput => "function_call_output",
                ResponseSteerInputItemDiscriminatorType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerInputItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function_call_output" => ResponseSteerInputItemDiscriminatorType.FunctionCallOutput,
                "message" => ResponseSteerInputItemDiscriminatorType.Message,
                _ => null,
            };
        }
    }
}