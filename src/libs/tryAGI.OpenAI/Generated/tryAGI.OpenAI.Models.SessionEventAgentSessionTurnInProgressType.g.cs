
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.in_progress`.<br/>
    /// Default Value: agent.session.turn.in_progress
    /// </summary>
    public enum SessionEventAgentSessionTurnInProgressType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnInProgressType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnInProgressType.AgentSessionTurnInProgress => "agent.session.turn.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.in_progress" => SessionEventAgentSessionTurnInProgressType.AgentSessionTurnInProgress,
                _ => null,
            };
        }
    }
}