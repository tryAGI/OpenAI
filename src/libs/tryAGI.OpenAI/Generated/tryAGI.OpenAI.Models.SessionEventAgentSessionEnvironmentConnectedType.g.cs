
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.connected`.<br/>
    /// Default Value: agent.session.environment.connected
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentConnectedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentConnected,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentConnectedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentConnectedType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentConnectedType.AgentSessionEnvironmentConnected => "agent.session.environment.connected",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentConnectedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.connected" => SessionEventAgentSessionEnvironmentConnectedType.AgentSessionEnvironmentConnected,
                _ => null,
            };
        }
    }
}