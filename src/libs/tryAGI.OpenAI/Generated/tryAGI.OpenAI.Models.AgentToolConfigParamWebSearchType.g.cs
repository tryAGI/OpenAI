
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `web_search`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum AgentToolConfigParamWebSearchType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolConfigParamWebSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigParamWebSearchType value)
        {
            return value switch
            {
                AgentToolConfigParamWebSearchType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigParamWebSearchType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => AgentToolConfigParamWebSearchType.WebSearch,
                _ => null,
            };
        }
    }
}