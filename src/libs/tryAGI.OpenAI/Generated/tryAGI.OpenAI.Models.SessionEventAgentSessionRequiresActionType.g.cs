
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `agent.session.requires_action`.<br/>
    /// Default Value: agent.session.requires_action
    /// </summary>
    public enum SessionEventAgentSessionRequiresActionType
    {
        /// <summary>
        ///
        /// </summary>
        AgentSessionRequiresAction,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SessionEventAgentSessionRequiresActionTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SessionEventAgentSessionRequiresActionType value)
        {
            return value switch
            {
                SessionEventAgentSessionRequiresActionType.AgentSessionRequiresAction => "agent.session.requires_action",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SessionEventAgentSessionRequiresActionType? ToEnum(string value)
        {
            return value switch
            {
                "agent.session.requires_action" => SessionEventAgentSessionRequiresActionType.AgentSessionRequiresAction,
                _ => null,
            };
        }
    }
}