
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `open_page`.<br/>
    /// Default Value: open_page
    /// </summary>
    public enum WebSearchActionResourceOpenPageType
    {
        /// <summary>
        ///
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionResourceOpenPageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionResourceOpenPageType value)
        {
            return value switch
            {
                WebSearchActionResourceOpenPageType.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionResourceOpenPageType? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => WebSearchActionResourceOpenPageType.OpenPage,
                _ => null,
            };
        }
    }
}