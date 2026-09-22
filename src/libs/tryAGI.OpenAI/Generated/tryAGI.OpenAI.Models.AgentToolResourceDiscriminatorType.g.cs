
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum AgentToolResourceDiscriminatorType
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
        WebSearch,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentToolResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentToolResourceDiscriminatorType value)
        {
            return value switch
            {
                AgentToolResourceDiscriminatorType.Function => "function",
                AgentToolResourceDiscriminatorType.Mcp => "mcp",
                AgentToolResourceDiscriminatorType.ProgrammaticToolCalling => "programmatic_tool_calling",
                AgentToolResourceDiscriminatorType.WebSearch => "web_search",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentToolResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "function" => AgentToolResourceDiscriminatorType.Function,
                "mcp" => AgentToolResourceDiscriminatorType.Mcp,
                "programmatic_tool_calling" => AgentToolResourceDiscriminatorType.ProgrammaticToolCalling,
                "web_search" => AgentToolResourceDiscriminatorType.WebSearch,
                _ => null,
            };
        }
    }
}