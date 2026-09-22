
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.item.added`.<br/>
    /// Default Value: agent.session.turn.item.added
    /// </summary>
    public enum SessionEventAgentSessionTurnItemAddedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnItemAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnItemAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnItemAddedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnItemAddedType.AgentSessionTurnItemAdded => "agent.session.turn.item.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnItemAddedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.item.added" => SessionEventAgentSessionTurnItemAddedType.AgentSessionTurnItemAdded,
                _ => null,
            };
        }
    }
}