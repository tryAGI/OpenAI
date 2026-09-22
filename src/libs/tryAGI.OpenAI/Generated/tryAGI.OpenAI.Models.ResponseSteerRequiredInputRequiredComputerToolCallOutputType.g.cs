
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredComputerToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ComputerCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredComputerToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredComputerToolCallOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredComputerToolCallOutputType.ComputerCallOutput => "computer_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredComputerToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "computer_call_output" => ResponseSteerRequiredInputRequiredComputerToolCallOutputType.ComputerCallOutput,
                _ => null,
            };
        }
    }
}