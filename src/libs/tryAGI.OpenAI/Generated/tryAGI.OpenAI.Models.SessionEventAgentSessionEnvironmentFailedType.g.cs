
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.failed`.<br/>
    /// Default Value: agent.session.environment.failed
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentFailedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentFailedType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentFailedType.AgentSessionEnvironmentFailed => "agent.session.environment.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentFailedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.failed" => SessionEventAgentSessionEnvironmentFailedType.AgentSessionEnvironmentFailed,
                _ => null,
            };
        }
    }
}