
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.input.cancel`.<br/>
    /// Default Value: agent.session.input.cancel
    /// </summary>
    public enum SessionInputParamAgentSessionInputCancelType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionInputCancel,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionInputParamAgentSessionInputCancelTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionInputParamAgentSessionInputCancelType value)
        {
            return value switch
            {
                SessionInputParamAgentSessionInputCancelType.AgentSessionInputCancel => "agent.session.input.cancel",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionInputParamAgentSessionInputCancelType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.input.cancel" => SessionInputParamAgentSessionInputCancelType.AgentSessionInputCancel,
                _ => null,
            };
        }
    }
}