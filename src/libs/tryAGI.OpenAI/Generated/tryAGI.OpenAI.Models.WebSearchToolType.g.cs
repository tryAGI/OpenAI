
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the web search tool. One of `web_search` or `web_search_2025_08_26`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum WebSearchToolType
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
    public static class WebSearchToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolType value)
        {
            return value switch
            {
                WebSearchToolType.WebSearch => "web_search",
                WebSearchToolType.WebSearch20250826 => "web_search_2025_08_26",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => WebSearchToolType.WebSearch,
                "web_search_2025_08_26" => WebSearchToolType.WebSearch20250826,
                _ => null,
            };
        }
    }
}