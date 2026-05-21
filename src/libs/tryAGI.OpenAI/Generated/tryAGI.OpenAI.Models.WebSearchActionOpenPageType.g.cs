
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The action type.
    /// </summary>
    public enum WebSearchActionOpenPageType
    {
        /// <summary>
        /// 
        /// </summary>
        OpenPage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionOpenPageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionOpenPageType value)
        {
            return value switch
            {
                WebSearchActionOpenPageType.OpenPage => "open_page",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionOpenPageType? ToEnum(string value)
        {
            return value switch
            {
                "open_page" => WebSearchActionOpenPageType.OpenPage,
                _ => null,
            };
        }
    }
}