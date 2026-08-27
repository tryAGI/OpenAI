
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `multi_agent_call_output`.<br/>
    /// Default Value: multi_agent_call_output
    /// </summary>
    public enum BetaMultiAgentCallOutputItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        MultiAgentCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMultiAgentCallOutputItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentCallOutputItemParamType value)
        {
            return value switch
            {
                BetaMultiAgentCallOutputItemParamType.MultiAgentCallOutput => "multi_agent_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentCallOutputItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "multi_agent_call_output" => BetaMultiAgentCallOutputItemParamType.MultiAgentCallOutput,
                _ => null,
            };
        }
    }
}