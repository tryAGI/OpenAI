
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `create_subagent_call`.<br/>
    /// Default Value: create_subagent_call
    /// </summary>
    public enum CreateSubagentCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        CreateSubagentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSubagentCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSubagentCallItemResourceType value)
        {
            return value switch
            {
                CreateSubagentCallItemResourceType.CreateSubagentCall => "create_subagent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSubagentCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "create_subagent_call" => CreateSubagentCallItemResourceType.CreateSubagentCall,
                _ => null,
            };
        }
    }
}