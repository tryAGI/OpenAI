
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `web_search`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum LiveSpecificWebSearchParamType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificWebSearchParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificWebSearchParamType value)
        {
            return value switch
            {
                LiveSpecificWebSearchParamType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificWebSearchParamType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => LiveSpecificWebSearchParamType.WebSearch,
                _ => null,
            };
        }
    }
}