
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.failed`.<br/>
    /// Default Value: agent.session.turn.failed
    /// </summary>
    public enum SessionEventAgentSessionTurnFailedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnFailedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnFailedType.AgentSessionTurnFailed => "agent.session.turn.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnFailedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.failed" => SessionEventAgentSessionTurnFailedType.AgentSessionTurnFailed,
                _ => null,
            };
        }
    }
}