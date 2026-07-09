
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `tool_search_output`.<br/>
    /// Default Value: tool_search_output
    /// </summary>
    public enum BetaToolSearchOutputType
    {
        /// <summary>
        /// 
        /// </summary>
        ToolSearchOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchOutputType value)
        {
            return value switch
            {
                BetaToolSearchOutputType.ToolSearchOutput => "tool_search_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchOutputType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search_output" => BetaToolSearchOutputType.ToolSearchOutput,
                _ => null,
            };
        }
    }
}