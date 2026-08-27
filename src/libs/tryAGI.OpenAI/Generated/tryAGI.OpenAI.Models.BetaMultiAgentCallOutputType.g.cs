
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the multi-agent result. Always `multi_agent_call_output`.<br/>
    /// Default Value: multi_agent_call_output
    /// </summary>
    public enum BetaMultiAgentCallOutputType
    {
        /// <summary>
        ///
        /// </summary>
        MultiAgentCallOutput,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaMultiAgentCallOutputTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaMultiAgentCallOutputType value)
        {
            return value switch
            {
                BetaMultiAgentCallOutputType.MultiAgentCallOutput => "multi_agent_call_output",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaMultiAgentCallOutputType? ToEnum(string value)
        {
            return value switch
            {
                "multi_agent_call_output" => BetaMultiAgentCallOutputType.MultiAgentCallOutput,
                _ => null,
            };
        }
    }
}