
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the item. Always `agent_message`.<br/>
    /// Default Value: agent_message
    /// </summary>
    public enum BetaAgentMessageType
    {
        /// <summary>
        /// 
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAgentMessageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAgentMessageType value)
        {
            return value switch
            {
                BetaAgentMessageType.AgentMessage => "agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAgentMessageType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => BetaAgentMessageType.AgentMessage,
                _ => null,
            };
        }
    }
}