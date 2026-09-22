
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredCustomToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredCustomToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredCustomToolCallOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredCustomToolCallOutputType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredCustomToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => ResponseSteerRequiredInputRequiredCustomToolCallOutputType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}