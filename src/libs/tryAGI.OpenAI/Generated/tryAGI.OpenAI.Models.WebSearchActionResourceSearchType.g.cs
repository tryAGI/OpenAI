
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `search`.<br/>
    /// Default Value: search
    /// </summary>
    public enum WebSearchActionResourceSearchType
    {
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionResourceSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionResourceSearchType value)
        {
            return value switch
            {
                WebSearchActionResourceSearchType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionResourceSearchType? ToEnum(string value)
        {
            return value switch
            {
                "search" => WebSearchActionResourceSearchType.Search,
                _ => null,
            };
        }
    }
}