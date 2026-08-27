
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum BetaWebSearchToolType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
        /// <summary>
        ///
        /// </summary>
        WebSearch20250826,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolType value)
        {
            return value switch
            {
                BetaWebSearchToolType.WebSearch => "web_search",
                BetaWebSearchToolType.WebSearch20250826 => "web_search_2025_08_26",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => BetaWebSearchToolType.WebSearch,
                "web_search_2025_08_26" => BetaWebSearchToolType.WebSearch20250826,
                _ => null,
            };
        }
    }
}