
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of source. Always `url`.
    /// </summary>
    public enum WebSearchActionSearchSourceType
    {
        /// <summary>
        /// 
        /// </summary>
        Url,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionSearchSourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionSearchSourceType value)
        {
            return value switch
            {
                WebSearchActionSearchSourceType.Url => "url",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionSearchSourceType? ToEnum(string value)
        {
            return value switch
            {
                "url" => WebSearchActionSearchSourceType.Url,
                _ => null,
            };
        }
    }
}