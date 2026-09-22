
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `web_search_call`.<br/>
    /// Default Value: web_search_call
    /// </summary>
    public enum WebSearchCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearchCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchCallItemResourceType value)
        {
            return value switch
            {
                WebSearchCallItemResourceType.WebSearchCall => "web_search_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "web_search_call" => WebSearchCallItemResourceType.WebSearchCall,
                _ => null,
            };
        }
    }
}