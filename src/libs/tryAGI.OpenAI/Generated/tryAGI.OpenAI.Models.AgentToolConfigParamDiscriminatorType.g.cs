
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentToolConfigParamDiscriminatorType
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
    public static class AgentToolConfigParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolConfigParamDiscriminatorType value)
        {
            return value switch
            {
                AgentToolConfigParamDiscriminatorType.Function => "function",
                AgentToolConfigParamDiscriminatorType.Mcp => "mcp",
                AgentToolConfigParamDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                AgentToolConfigParamDiscriminatorType.ToolSearch => "tool_search",
                AgentToolConfigParamDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolConfigParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => AgentToolConfigParamDiscriminatorType.Function,
                "mcp" => AgentToolConfigParamDiscriminatorType.Mcp,
                "programmatic_tool_calling" => AgentToolConfigParamDiscriminatorType.ProgrammaticToolCalling,
                "tool_search" => AgentToolConfigParamDiscriminatorType.ToolSearch,
                "web_search" => AgentToolConfigParamDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}