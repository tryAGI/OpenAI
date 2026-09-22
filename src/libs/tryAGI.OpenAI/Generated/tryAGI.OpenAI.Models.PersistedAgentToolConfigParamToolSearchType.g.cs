
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `tool_search`.<br/>
    /// Default Value: tool_search
    /// </summary>
    public enum PersistedAgentToolConfigParamToolSearchType
    {
        /// <summary>
        ///
        /// </summary>
        ToolSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolConfigParamToolSearchTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamToolSearchType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamToolSearchType.ToolSearch => "tool_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamToolSearchType? ToEnum(string value)
        {
            return value switch
            {
                "tool_search" => PersistedAgentToolConfigParamToolSearchType.ToolSearch,
                _ => null,
            };
        }
    }
}