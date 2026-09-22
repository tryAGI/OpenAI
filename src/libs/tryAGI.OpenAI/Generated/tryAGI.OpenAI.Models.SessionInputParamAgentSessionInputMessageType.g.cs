
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.input.message`.<br/>
    /// Default Value: agent.session.input.message
    /// </summary>
    public enum SessionInputParamAgentSessionInputMessageType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamAgentSessionInputMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamAgentSessionInputMessageType value)
        {
            return value switch
            {
                SessionInputParamAgentSessionInputMessageType.AgentSessionInputMessage => "agent.session.input.message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamAgentSessionInputMessageType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.message" => SessionInputParamAgentSessionInputMessageType.AgentSessionInputMessage,
                _ => null,
            };
        }
    }
}