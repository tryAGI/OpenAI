
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.expired`.<br/>
    /// Default Value: agent.session.environment.expired
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentExpiredType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentExpiredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentExpiredType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentExpiredType.AgentSessionEnvironmentExpired => "agent.session.environment.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentExpiredType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.expired" => SessionEventAgentSessionEnvironmentExpiredType.AgentSessionEnvironmentExpired,
                _ => null,
            };
        }
    }
}