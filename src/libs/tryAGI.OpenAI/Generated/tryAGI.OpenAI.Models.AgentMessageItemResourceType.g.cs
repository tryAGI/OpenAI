
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `agent_message`.<br/>
    /// Default Value: agent_message
    /// </summary>
    public enum AgentMessageItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AgentMessageItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AgentMessageItemResourceType value)
        {
            return value switch
            {
                AgentMessageItemResourceType.AgentMessage => "agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AgentMessageItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => AgentMessageItemResourceType.AgentMessage,
                _ => null,
            };
        }
    }
}