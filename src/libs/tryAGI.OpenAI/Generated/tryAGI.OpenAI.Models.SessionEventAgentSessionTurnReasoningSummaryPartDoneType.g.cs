
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.reasoning_summary_part.done`.<br/>
    /// Default Value: agent.session.turn.reasoning_summary_part.done
    /// </summary>
    public enum SessionEventAgentSessionTurnReasoningSummaryPartDoneType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryPartDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnReasoningSummaryPartDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnReasoningSummaryPartDoneType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnReasoningSummaryPartDoneType.AgentSessionTurnReasoningSummaryPartDone => "agent.session.turn.reasoning_summary_part.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnReasoningSummaryPartDoneType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.reasoning_summary_part.done" => SessionEventAgentSessionTurnReasoningSummaryPartDoneType.AgentSessionTurnReasoningSummaryPartDone,
                _ => null,
            };
        }
    }
}