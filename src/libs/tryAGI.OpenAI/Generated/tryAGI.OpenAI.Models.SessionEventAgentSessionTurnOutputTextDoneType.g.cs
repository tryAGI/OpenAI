
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.output_text.done`.<br/>
    /// Default Value: agent.session.turn.output_text.done
    /// </summary>
    public enum SessionEventAgentSessionTurnOutputTextDoneType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnOutputTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnOutputTextDoneType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnOutputTextDoneType.AgentSessionTurnOutputTextDone => "agent.session.turn.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnOutputTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.output_text.done" => SessionEventAgentSessionTurnOutputTextDoneType.AgentSessionTurnOutputTextDone,
                _ => null,
            };
        }
    }
}