
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `interrupt_subagent_call`.<br/>
    /// Default Value: interrupt_subagent_call
    /// </summary>
    public enum InterruptSubagentCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        InterruptSubagentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class InterruptSubagentCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InterruptSubagentCallItemResourceType value)
        {
            return value switch
            {
                InterruptSubagentCallItemResourceType.InterruptSubagentCall => "interrupt_subagent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InterruptSubagentCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "interrupt_subagent_call" => InterruptSubagentCallItemResourceType.InterruptSubagentCall,
                _ => null,
            };
        }
    }
}