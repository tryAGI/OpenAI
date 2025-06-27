
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The action type.
    /// </summary>
    public enum WebSearchActionSearchType
    {
        /// <summary>
        /// 
        /// </summary>
        Search,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionSearchType value)
        {
            return value switch
            {
                WebSearchActionSearchType.Search => "search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionSearchType? ToEnum(string value)
        {
            return value switch
            {
                "search" => WebSearchActionSearchType.Search,
                _ => null,
            };
        }
    }
}