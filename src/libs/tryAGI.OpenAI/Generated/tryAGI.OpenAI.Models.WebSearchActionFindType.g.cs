
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The action type.
    /// </summary>
    public enum WebSearchActionFindType
    {
        /// <summary>
        /// 
        /// </summary>
        Find,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebSearchActionFindTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebSearchActionFindType value)
        {
            return value switch
            {
                WebSearchActionFindType.Find => "find",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebSearchActionFindType? ToEnum(string value)
        {
            return value switch
            {
                "find" => WebSearchActionFindType.Find,
                _ => null,
            };
        }
    }
}