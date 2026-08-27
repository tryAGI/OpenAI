
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `multi_agent_call`.<br/>
    /// Default Value: multi_agent_call
    /// </summary>
    public enum BetaMultiAgentCallItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        MultiAgentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMultiAgentCallItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentCallItemParamType value)
        {
            return value switch
            {
                BetaMultiAgentCallItemParamType.MultiAgentCall => "multi_agent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentCallItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "multi_agent_call" => BetaMultiAgentCallItemParamType.MultiAgentCall,
                _ => null,
            };
        }
    }
}