
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `wait_for_subagents_call`.<br/>
    /// Default Value: wait_for_subagents_call
    /// </summary>
    public enum WaitForSubagentsCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        WaitForSubagentsCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WaitForSubagentsCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WaitForSubagentsCallItemResourceType value)
        {
            return value switch
            {
                WaitForSubagentsCallItemResourceType.WaitForSubagentsCall => "wait_for_subagents_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WaitForSubagentsCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "wait_for_subagents_call" => WaitForSubagentsCallItemResourceType.WaitForSubagentsCall,
                _ => null,
            };
        }
    }
}