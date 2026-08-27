
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the tool. Always `tool_search`.<br/>
    /// Default Value: tool_search
    /// </summary>
    public enum BetaToolSearchToolParamType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaToolSearchToolParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaToolSearchToolParamType value)
        {
            return value switch
            {
                BetaToolSearchToolParamType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaToolSearchToolParamType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search" => BetaToolSearchToolParamType.ToolSearch,
                _ => null,
            };
        }
    }
}