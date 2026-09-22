
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.item.done`.<br/>
    /// Default Value: agent.session.turn.item.done
    /// </summary>
    public enum SessionEventAgentSessionTurnItemDoneType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnItemDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnItemDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnItemDoneType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnItemDoneType.AgentSessionTurnItemDone => "agent.session.turn.item.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnItemDoneType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.item.done" => SessionEventAgentSessionTurnItemDoneType.AgentSessionTurnItemDone,
                _ => null,
            };
        }
    }
}