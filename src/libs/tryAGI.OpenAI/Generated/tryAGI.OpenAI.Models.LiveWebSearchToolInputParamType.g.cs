
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool type. Always `web_search`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum LiveWebSearchToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveWebSearchToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveWebSearchToolInputParamType value)
        {
            return value switch
            {
                LiveWebSearchToolInputParamType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveWebSearchToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => LiveWebSearchToolInputParamType.WebSearch,
                _ => null,
            };
        }
    }
}