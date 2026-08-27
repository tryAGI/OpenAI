
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `tool_search_output`.<br/>
    /// Default Value: tool_search_output
    /// </summary>
    public enum BetaToolSearchOutputItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputItemParamType value)
        {
            return value switch
            {
                BetaToolSearchOutputItemParamType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_output" => BetaToolSearchOutputItemParamType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}