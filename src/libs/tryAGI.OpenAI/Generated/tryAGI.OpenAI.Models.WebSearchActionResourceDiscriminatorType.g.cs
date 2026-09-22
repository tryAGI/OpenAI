
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebSearchActionResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        FindInPage,
        /// <summary>
        ///
        /// </summary>
        OpenPage,
        /// <summary>
        ///
        /// </summary>
        Other,
        /// <summary>
        ///
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionResourceDiscriminatorType value)
        {
            return value switch
            {
                WebSearchActionResourceDiscriminatorType.FindInPage => "find_in_page",
                WebSearchActionResourceDiscriminatorType.OpenPage => "open_page",
                WebSearchActionResourceDiscriminatorType.Other => "other",
                WebSearchActionResourceDiscriminatorType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => WebSearchActionResourceDiscriminatorType.FindInPage,
                "open_page" => WebSearchActionResourceDiscriminatorType.OpenPage,
                "other" => WebSearchActionResourceDiscriminatorType.Other,
                "search" => WebSearchActionResourceDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}