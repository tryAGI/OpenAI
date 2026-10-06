
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References a skill created with the /v1/skills endpoint.<br/>
    /// Default Value: skill_reference
    /// </summary>
    public enum LiveSkillReferenceParamType
    {
        /// <summary>
        ///
        /// </summary>
        SkillReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSkillReferenceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSkillReferenceParamType value)
        {
            return value switch
            {
                LiveSkillReferenceParamType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSkillReferenceParamType? ToEnum(string value)
        {
            return value switch
            {
                "skill_reference" => LiveSkillReferenceParamType.SkillReference,
                _ => null,
            };
        }
    }
}