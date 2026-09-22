
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.failed`.<br/>
    /// Default Value: agent.session.failed
    /// </summary>
    public enum SessionEventAgentSessionFailedType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionFailedType value)
        {
            return value switch
            {
                SessionEventAgentSessionFailedType.AgentSessionFailed => "agent.session.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionFailedType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.failed" => SessionEventAgentSessionFailedType.AgentSessionFailed,
                _ => null,
            };
        }
    }
}