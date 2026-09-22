
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.turn.content_part.added`.<br/>
    /// Default Value: agent.session.turn.content_part.added
    /// </summary>
    public enum SessionEventAgentSessionTurnContentPartAddedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTurnContentPartAdded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionTurnContentPartAddedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionTurnContentPartAddedType value)
        {
            return value switch
            {
                SessionEventAgentSessionTurnContentPartAddedType.AgentSessionTurnContentPartAdded => "agent.session.turn.content_part.added",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionTurnContentPartAddedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.turn.content_part.added" => SessionEventAgentSessionTurnContentPartAddedType.AgentSessionTurnContentPartAdded,
                _ => null,
            };
        }
    }
}