
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PersistedAgentToolResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Function,
        /// <summary>
        ///
        /// </summary>
        Mcp,
        /// <summary>
        ///
        /// </summary>
        ProgrammaticToolCalling,
        /// <summary>
        ///
        /// </summary>
        ToolSearch,
        /// <summary>
        ///
        /// </summary>
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PersistedAgentToolResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolResourceDiscriminatorType value)
        {
            return value switch
            {
                PersistedAgentToolResourceDiscriminatorType.Function => "function",
                PersistedAgentToolResourceDiscriminatorType.Mcp => "mcp",
                PersistedAgentToolResourceDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                PersistedAgentToolResourceDiscriminatorType.ToolSearch => "tool_search",
                PersistedAgentToolResourceDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PersistedAgentToolResourceDiscriminatorType.Function,
                "mcp" => PersistedAgentToolResourceDiscriminatorType.Mcp,
                "programmatic_tool_calling" => PersistedAgentToolResourceDiscriminatorType.ProgrammaticToolCalling,
                "tool_search" => PersistedAgentToolResourceDiscriminatorType.ToolSearch,
                "web_search" => PersistedAgentToolResourceDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}