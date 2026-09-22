
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.reasoning_summary_text.delta`.<br/>
    /// Default Value: agent.session.turn.reasoning_summary_text.delta
    /// </summary>
    public enum SessionEventAgentSessionTurnReasoningSummaryTextDeltaType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnReasoningSummaryTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnReasoningSummaryTextDeltaType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnReasoningSummaryTextDeltaType.AgentSessionTurnReasoningSummaryTextDelta => "agent.session.turn.reasoning_summary_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnReasoningSummaryTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.reasoning_summary_text.delta" => SessionEventAgentSessionTurnReasoningSummaryTextDeltaType.AgentSessionTurnReasoningSummaryTextDelta,
                _ => null,
            };
        }
    }
}