
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `tool_search`.<br/>
    /// Default Value: tool_search
    /// </summary>
    public enum PersistedAgentToolResourceToolSearchType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolResourceToolSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolResourceToolSearchType value)
        {
            return value switch
            {
                PersistedAgentToolResourceToolSearchType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolResourceToolSearchType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search" => PersistedAgentToolResourceToolSearchType.ToolSearch,
                _ => null,
            };
        }
    }
}