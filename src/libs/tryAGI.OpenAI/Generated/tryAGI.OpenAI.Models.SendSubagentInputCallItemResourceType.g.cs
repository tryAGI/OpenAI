
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `send_subagent_input_call`.<br/>
    /// Default Value: send_subagent_input_call
    /// </summary>
    public enum SendSubagentInputCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        SendSubagentInputCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SendSubagentInputCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SendSubagentInputCallItemResourceType value)
        {
            return value switch
            {
                SendSubagentInputCallItemResourceType.SendSubagentInputCall => "send_subagent_input_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SendSubagentInputCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "send_subagent_input_call" => SendSubagentInputCallItemResourceType.SendSubagentInputCall,
                _ => null,
            };
        }
    }
}