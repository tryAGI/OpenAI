
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `resume_subagent_call`.<br/>
    /// Default Value: resume_subagent_call
    /// </summary>
    public enum ResumeSubagentCallItemResourceType
    {
        /// <summary>
        ///
        /// </summary>
        ResumeSubagentCall,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResumeSubagentCallItemResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResumeSubagentCallItemResourceType value)
        {
            return value switch
            {
                ResumeSubagentCallItemResourceType.ResumeSubagentCall => "resume_subagent_call",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResumeSubagentCallItemResourceType? ToEnum(string value)
        {
            return value switch
            {
                "resume_subagent_call" => ResumeSubagentCallItemResourceType.ResumeSubagentCall,
                _ => null,
            };
        }
    }
}