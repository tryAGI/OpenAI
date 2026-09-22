
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum ResponseSteerRequiredInputRequiredToolSearchOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseSteerRequiredInputRequiredToolSearchOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseSteerRequiredInputRequiredToolSearchOutputType value)
        {
            return value switch
            {
                ResponseSteerRequiredInputRequiredToolSearchOutputType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseSteerRequiredInputRequiredToolSearchOutputType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_output" => ResponseSteerRequiredInputRequiredToolSearchOutputType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}