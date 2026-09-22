
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.pending`.<br/>
    /// Default Value: agent.session.environment.pending
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentPendingType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentPending,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentPendingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentPendingType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentPendingType.AgentSessionEnvironmentPending => "agent.session.environment.pending",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentPendingType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.pending" => SessionEventAgentSessionEnvironmentPendingType.AgentSessionEnvironmentPending,
                _ => null,
            };
        }
    }
}