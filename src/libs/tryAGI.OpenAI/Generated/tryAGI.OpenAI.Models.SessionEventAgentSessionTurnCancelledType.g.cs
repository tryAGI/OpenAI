
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.cancelled`.<br/>
    /// Default Value: agent.session.turn.cancelled
    /// </summary>
    public enum SessionEventAgentSessionTurnCancelledType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnCancelledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnCancelledType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnCancelledType.AgentSessionTurnCancelled => "agent.session.turn.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnCancelledType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.cancelled" => SessionEventAgentSessionTurnCancelledType.AgentSessionTurnCancelled,
                _ => null,
            };
        }
    }
}