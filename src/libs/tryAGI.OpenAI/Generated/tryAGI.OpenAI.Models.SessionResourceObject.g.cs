
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `agent.session`.<br/>
    /// Default Value: agent.session
    /// </summary>
    public enum SessionResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        AgentSession,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionResourceObject value)
        {
            return value switch
            {
                SessionResourceObject.AgentSession => "agent.session",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "agent.session" => SessionResourceObject.AgentSession,
                _ => null,
            };
        }
    }
}