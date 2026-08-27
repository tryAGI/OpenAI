
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the custom tool call output. Always `custom_tool_call_output`.
    /// </summary>
    public enum BetaCustomToolCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        CustomToolCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomToolCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomToolCallOutputType value)
        {
            return value switch
            {
                BetaCustomToolCallOutputType.CustomToolCallOutput => "custom_tool_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomToolCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "custom_tool_call_output" => BetaCustomToolCallOutputType.CustomToolCallOutput,
                _ => null,
            };
        }
    }
}