
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredCustomToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => BetaResponseSteerRequiredInputRequiredCustomToolCallOutputType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}