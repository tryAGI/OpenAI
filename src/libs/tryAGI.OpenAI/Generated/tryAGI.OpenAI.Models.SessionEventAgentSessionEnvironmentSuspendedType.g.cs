
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.suspended`.<br/>
    /// Default Value: agent.session.environment.suspended
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentSuspendedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentSuspended,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentSuspendedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentSuspendedType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentSuspendedType.AgentSessionEnvironmentSuspended => "agent.session.environment.suspended",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentSuspendedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.suspended" => SessionEventAgentSessionEnvironmentSuspendedType.AgentSessionEnvironmentSuspended,
                _ => null,
            };
        }
    }
}