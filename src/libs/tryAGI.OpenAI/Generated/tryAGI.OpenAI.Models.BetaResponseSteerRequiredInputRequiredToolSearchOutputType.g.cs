
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaResponseSteerRequiredInputRequiredToolSearchOutputType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseSteerRequiredInputRequiredToolSearchOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseSteerRequiredInputRequiredToolSearchOutputType value)
        {
            return value switch
            {
                BetaResponseSteerRequiredInputRequiredToolSearchOutputType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseSteerRequiredInputRequiredToolSearchOutputType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_output" => BetaResponseSteerRequiredInputRequiredToolSearchOutputType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}