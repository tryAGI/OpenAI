
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.disconnected`.<br/>
    /// Default Value: agent.session.environment.disconnected
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentDisconnectedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentDisconnected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentDisconnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentDisconnectedType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentDisconnectedType.AgentSessionEnvironmentDisconnected => "agent.session.environment.disconnected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentDisconnectedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.disconnected" => SessionEventAgentSessionEnvironmentDisconnectedType.AgentSessionEnvironmentDisconnected,
                _ => null,
            };
        }
    }
}