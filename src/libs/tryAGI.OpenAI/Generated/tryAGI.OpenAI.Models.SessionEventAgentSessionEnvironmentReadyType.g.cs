
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.ready`.<br/>
    /// Default Value: agent.session.environment.ready
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentReadyType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentReady,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentReadyTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentReadyType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentReadyType.AgentSessionEnvironmentReady => "agent.session.environment.ready",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentReadyType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.ready" => SessionEventAgentSessionEnvironmentReadyType.AgentSessionEnvironmentReady,
                _ => null,
            };
        }
    }
}