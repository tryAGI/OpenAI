
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum PersistedAgentToolConfigParamDiscriminatorType
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
    public static class PersistedAgentToolConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PersistedAgentToolConfigParamDiscriminatorType value)
        {
            return value switch
            {
                PersistedAgentToolConfigParamDiscriminatorType.Function => "function",
                PersistedAgentToolConfigParamDiscriminatorType.Mcp => "mcp",
                PersistedAgentToolConfigParamDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                PersistedAgentToolConfigParamDiscriminatorType.ToolSearch => "tool_search",
                PersistedAgentToolConfigParamDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PersistedAgentToolConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => PersistedAgentToolConfigParamDiscriminatorType.Function,
                "mcp" => PersistedAgentToolConfigParamDiscriminatorType.Mcp,
                "programmatic_tool_calling" => PersistedAgentToolConfigParamDiscriminatorType.ProgrammaticToolCalling,
                "tool_search" => PersistedAgentToolConfigParamDiscriminatorType.ToolSearch,
                "web_search" => PersistedAgentToolConfigParamDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}