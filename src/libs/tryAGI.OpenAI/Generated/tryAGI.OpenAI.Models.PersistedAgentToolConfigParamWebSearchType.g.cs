
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `web_search`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum PersistedAgentToolConfigParamWebSearchType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolConfigParamWebSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamWebSearchType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamWebSearchType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamWebSearchType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => PersistedAgentToolConfigParamWebSearchType.WebSearch,
                _ => null,
            };
        }
    }
}