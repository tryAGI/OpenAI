
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `close_subagent_call`.<br/>
    /// Default Value: close_subagent_call
    /// </summary>
    public enum CloseSubagentCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        CloseSubagentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CloseSubagentCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CloseSubagentCallItemResourceType value)
        {
            return value switch
            {
                CloseSubagentCallItemResourceType.CloseSubagentCall => "close_subagent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CloseSubagentCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "close_subagent_call" => CloseSubagentCallItemResourceType.CloseSubagentCall,
                _ => null,
            };
        }
    }
}