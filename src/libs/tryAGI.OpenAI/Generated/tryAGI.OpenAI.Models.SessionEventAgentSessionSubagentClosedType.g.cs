
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.subagent.closed`.<br/>
    /// Default Value: agent.session.subagent.closed
    /// </summary>
    public enum SessionEventAgentSessionSubagentClosedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentClosed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionSubagentClosedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionSubagentClosedType value)
        {
            return value switch
            {
                SessionEventAgentSessionSubagentClosedType.AgentSessionSubagentClosed => "agent.session.subagent.closed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionSubagentClosedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.subagent.closed" => SessionEventAgentSessionSubagentClosedType.AgentSessionSubagentClosed,
                _ => null,
            };
        }
    }
}