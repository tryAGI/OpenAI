
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the multi-agent call. Always `multi_agent_call`.<br/>
    /// Default Value: multi_agent_call
    /// </summary>
    public enum BetaMultiAgentCallType
    {
        /// <summary>
        /// 
        /// </summary>
        MultiAgentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMultiAgentCallTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentCallType value)
        {
            return value switch
            {
                BetaMultiAgentCallType.MultiAgentCall => "multi_agent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentCallType? ToEnum(string value)
        {
            return value switch
            {
                "multi_agent_call" => BetaMultiAgentCallType.MultiAgentCall,
                _ => null,
            };
        }
    }
}