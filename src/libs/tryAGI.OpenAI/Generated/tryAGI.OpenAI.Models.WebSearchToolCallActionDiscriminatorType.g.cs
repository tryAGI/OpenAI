
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum WebSearchToolCallActionDiscriminatorType
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
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchToolCallActionDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchToolCallActionDiscriminatorType value)
        {
            return value switch
            {
                WebSearchToolCallActionDiscriminatorType.FindInPage => "find_in_page",
                WebSearchToolCallActionDiscriminatorType.OpenPage => "open_page",
                WebSearchToolCallActionDiscriminatorType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchToolCallActionDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "find_in_page" => WebSearchToolCallActionDiscriminatorType.FindInPage,
                "open_page" => WebSearchToolCallActionDiscriminatorType.OpenPage,
                "search" => WebSearchToolCallActionDiscriminatorType.Search,
                _ => null,
            };
        }
    }
}