
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.in_progress`.<br/>
    /// Default Value: agent.session.in_progress
    /// </summary>
    public enum SessionEventAgentSessionInProgressType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionInProgressTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionInProgressType value)
        {
            return value switch
            {
                SessionEventAgentSessionInProgressType.AgentSessionInProgress => "agent.session.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionInProgressType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.in_progress" => SessionEventAgentSessionInProgressType.AgentSessionInProgress,
                _ => null,
            };
        }
    }
}