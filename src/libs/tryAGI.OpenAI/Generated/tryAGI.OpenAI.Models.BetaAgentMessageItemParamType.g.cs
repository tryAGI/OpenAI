
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `agent_message`.<br/>
    /// Default Value: agent_message
    /// </summary>
    public enum BetaAgentMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        AgentMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaAgentMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaAgentMessageItemParamType value)
        {
            return value switch
            {
                BetaAgentMessageItemParamType.AgentMessage => "agent_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaAgentMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "agent_message" => BetaAgentMessageItemParamType.AgentMessage,
                _ => null,
            };
        }
    }
}