
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the web search tool call. Always `web_search_call`.
    /// </summary>
    public enum BetaWebSearchToolCallType
    {
        /// <summary>
        /// 
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaWebSearchToolCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaWebSearchToolCallType value)
        {
            return value switch
            {
                BetaWebSearchToolCallType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaWebSearchToolCallType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => BetaWebSearchToolCallType.WebSearchCall,
                _ => null,
            };
        }
    }
}