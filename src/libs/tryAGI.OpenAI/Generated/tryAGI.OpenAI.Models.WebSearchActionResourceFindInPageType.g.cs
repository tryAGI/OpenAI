
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `find_in_page`.<br/>
    /// Default Value: find_in_page
    /// </summary>
    public enum WebSearchActionResourceFindInPageType
    {
        /// <summary>
        ///
        /// </summary>
        FindInPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionResourceFindInPageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionResourceFindInPageType value)
        {
            return value switch
            {
                WebSearchActionResourceFindInPageType.FindInPage => "find_in_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionResourceFindInPageType? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => WebSearchActionResourceFindInPageType.FindInPage,
                _ => null,
            };
        }
    }
}