
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.completed`.<br/>
    /// Default Value: agent.session.turn.completed
    /// </summary>
    public enum SessionEventAgentSessionTurnCompletedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnCompletedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnCompletedType.AgentSessionTurnCompleted => "agent.session.turn.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.completed" => SessionEventAgentSessionTurnCompletedType.AgentSessionTurnCompleted,
                _ => null,
            };
        }
    }
}