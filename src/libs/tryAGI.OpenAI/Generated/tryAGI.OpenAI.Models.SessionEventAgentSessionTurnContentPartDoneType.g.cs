
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.content_part.done`.<br/>
    /// Default Value: agent.session.turn.content_part.done
    /// </summary>
    public enum SessionEventAgentSessionTurnContentPartDoneType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnContentPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnContentPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnContentPartDoneType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnContentPartDoneType.AgentSessionTurnContentPartDone => "agent.session.turn.content_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnContentPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.content_part.done" => SessionEventAgentSessionTurnContentPartDoneType.AgentSessionTurnContentPartDone,
                _ => null,
            };
        }
    }
}