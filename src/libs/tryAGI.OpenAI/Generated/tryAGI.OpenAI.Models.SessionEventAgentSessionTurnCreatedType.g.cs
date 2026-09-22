
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.created`.<br/>
    /// Default Value: agent.session.turn.created
    /// </summary>
    public enum SessionEventAgentSessionTurnCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnCreatedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnCreatedType.AgentSessionTurnCreated => "agent.session.turn.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.created" => SessionEventAgentSessionTurnCreatedType.AgentSessionTurnCreated,
                _ => null,
            };
        }
    }
}