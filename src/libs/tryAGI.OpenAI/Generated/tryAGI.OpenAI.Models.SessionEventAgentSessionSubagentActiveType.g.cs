
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.subagent.active`.<br/>
    /// Default Value: agent.session.subagent.active
    /// </summary>
    public enum SessionEventAgentSessionSubagentActiveType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentActive,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionSubagentActiveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionSubagentActiveType value)
        {
            return value switch
            {
                SessionEventAgentSessionSubagentActiveType.AgentSessionSubagentActive => "agent.session.subagent.active",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionSubagentActiveType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.subagent.active" => SessionEventAgentSessionSubagentActiveType.AgentSessionSubagentActive,
                _ => null,
            };
        }
    }
}