
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `skill_reference`.<br/>
    /// Default Value: skill_reference
    /// </summary>
    public enum HostedTemplateSkillResourceSkillReferenceType
    {
        /// <summary>
        ///
        /// </summary>
        SkillReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedTemplateSkillResourceSkillReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedTemplateSkillResourceSkillReferenceType value)
        {
            return value switch
            {
                HostedTemplateSkillResourceSkillReferenceType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedTemplateSkillResourceSkillReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "skill_reference" => HostedTemplateSkillResourceSkillReferenceType.SkillReference,
                _ => null,
            };
        }
    }
}