
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.reasoning_summary_part.added`.<br/>
    /// Default Value: agent.session.turn.reasoning_summary_part.added
    /// </summary>
    public enum SessionEventAgentSessionTurnReasoningSummaryPartAddedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnReasoningSummaryPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnReasoningSummaryPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnReasoningSummaryPartAddedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnReasoningSummaryPartAddedType.AgentSessionTurnReasoningSummaryPartAdded => "agent.session.turn.reasoning_summary_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnReasoningSummaryPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.reasoning_summary_part.added" => SessionEventAgentSessionTurnReasoningSummaryPartAddedType.AgentSessionTurnReasoningSummaryPartAdded,
                _ => null,
            };
        }
    }
}