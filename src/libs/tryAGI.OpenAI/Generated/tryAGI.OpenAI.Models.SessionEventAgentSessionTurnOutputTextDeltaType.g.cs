
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.output_text.delta`.<br/>
    /// Default Value: agent.session.turn.output_text.delta
    /// </summary>
    public enum SessionEventAgentSessionTurnOutputTextDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnOutputTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnOutputTextDeltaType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnOutputTextDeltaType.AgentSessionTurnOutputTextDelta => "agent.session.turn.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnOutputTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.output_text.delta" => SessionEventAgentSessionTurnOutputTextDeltaType.AgentSessionTurnOutputTextDelta,
                _ => null,
            };
        }
    }
}