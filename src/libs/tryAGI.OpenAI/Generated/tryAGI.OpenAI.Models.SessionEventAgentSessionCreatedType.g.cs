
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.created`.<br/>
    /// Default Value: agent.session.created
    /// </summary>
    public enum SessionEventAgentSessionCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionCreatedType value)
        {
            return value switch
            {
                SessionEventAgentSessionCreatedType.AgentSessionCreated => "agent.session.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.created" => SessionEventAgentSessionCreatedType.AgentSessionCreated,
                _ => null,
            };
        }
    }
}