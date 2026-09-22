
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.environment.reset`.<br/>
    /// Default Value: agent.session.environment.reset
    /// </summary>
    public enum SessionEventAgentSessionEnvironmentResetType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionEnvironmentReset,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionEnvironmentResetTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionEnvironmentResetType value)
        {
            return value switch
            {
                SessionEventAgentSessionEnvironmentResetType.AgentSessionEnvironmentReset => "agent.session.environment.reset",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionEnvironmentResetType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.environment.reset" => SessionEventAgentSessionEnvironmentResetType.AgentSessionEnvironmentReset,
                _ => null,
            };
        }
    }
}