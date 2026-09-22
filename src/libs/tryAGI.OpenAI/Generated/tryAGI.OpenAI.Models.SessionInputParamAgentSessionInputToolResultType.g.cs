
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.input.tool_result`.<br/>
    /// Default Value: agent.session.input.tool_result
    /// </summary>
    public enum SessionInputParamAgentSessionInputToolResultType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputToolResult,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamAgentSessionInputToolResultTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamAgentSessionInputToolResultType value)
        {
            return value switch
            {
                SessionInputParamAgentSessionInputToolResultType.AgentSessionInputToolResult => "agent.session.input.tool_result",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamAgentSessionInputToolResultType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.tool_result" => SessionInputParamAgentSessionInputToolResultType.AgentSessionInputToolResult,
                _ => null,
            };
        }
    }
}