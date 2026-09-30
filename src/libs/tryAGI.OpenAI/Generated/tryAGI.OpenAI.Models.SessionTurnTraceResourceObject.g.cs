
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `agent.session.trace`.<br/>
    /// Default Value: agent.session.trace
    /// </summary>
    public enum SessionTurnTraceResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionTrace,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionTurnTraceResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionTurnTraceResourceObject value)
        {
            return value switch
            {
                SessionTurnTraceResourceObject.AgentSessionTrace => "agent.session.trace",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionTurnTraceResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.trace" => SessionTurnTraceResourceObject.AgentSessionTrace,
                _ => null,
            };
        }
    }
}