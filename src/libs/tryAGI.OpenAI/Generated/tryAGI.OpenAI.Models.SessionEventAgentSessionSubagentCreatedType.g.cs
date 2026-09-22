
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.subagent.created`.<br/>
    /// Default Value: agent.session.subagent.created
    /// </summary>
    public enum SessionEventAgentSessionSubagentCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionSubagentCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionSubagentCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionSubagentCreatedType value)
        {
            return value switch
            {
                SessionEventAgentSessionSubagentCreatedType.AgentSessionSubagentCreated => "agent.session.subagent.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionSubagentCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.subagent.created" => SessionEventAgentSessionSubagentCreatedType.AgentSessionSubagentCreated,
                _ => null,
            };
        }
    }
}