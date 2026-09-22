
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.idle`.<br/>
    /// Default Value: agent.session.idle
    /// </summary>
    public enum SessionEventAgentSessionIdleType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionIdle,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionIdleTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionIdleType value)
        {
            return value switch
            {
                SessionEventAgentSessionIdleType.AgentSessionIdle => "agent.session.idle",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionIdleType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.idle" => SessionEventAgentSessionIdleType.AgentSessionIdle,
                _ => null,
            };
        }
    }
}