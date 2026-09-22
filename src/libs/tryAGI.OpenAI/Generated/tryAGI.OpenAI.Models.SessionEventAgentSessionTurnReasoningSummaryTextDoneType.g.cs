
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.reasoning_summary_text.done`.<br/>
    /// Default Value: agent.session.turn.reasoning_summary_text.done
    /// </summary>
    public enum SessionEventAgentSessionTurnReasoningSummaryTextDoneType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnReasoningSummaryTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnReasoningSummaryTextDoneType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnReasoningSummaryTextDoneType.AgentSessionTurnReasoningSummaryTextDone => "agent.session.turn.reasoning_summary_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnReasoningSummaryTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.reasoning_summary_text.done" => SessionEventAgentSessionTurnReasoningSummaryTextDoneType.AgentSessionTurnReasoningSummaryTextDone,
                _ => null,
            };
        }
    }
}