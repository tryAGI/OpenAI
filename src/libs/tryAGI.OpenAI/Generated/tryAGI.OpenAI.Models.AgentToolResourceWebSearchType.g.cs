
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `web_search`.<br/>
    /// Default Value: web_search
    /// </summary>
    public enum AgentToolResourceWebSearchType
    {
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceWebSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceWebSearchType value)
        {
            return value switch
            {
                AgentToolResourceWebSearchType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceWebSearchType? ToEnum(string value)
        {
            return value switch
            {
                "web_search" => AgentToolResourceWebSearchType.WebSearch,
                _ => null,
            };
        }
    }
}