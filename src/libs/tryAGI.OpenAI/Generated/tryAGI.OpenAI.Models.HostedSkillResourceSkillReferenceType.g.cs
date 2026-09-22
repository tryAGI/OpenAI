
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `skill_reference`.<br/>
    /// Default Value: skill_reference
    /// </summary>
    public enum HostedSkillResourceSkillReferenceType
    {
        /// <summary>
        ///
        /// </summary>
        SkillReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedSkillResourceSkillReferenceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedSkillResourceSkillReferenceType value)
        {
            return value switch
            {
                HostedSkillResourceSkillReferenceType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedSkillResourceSkillReferenceType? ToEnum(string value)
        {
            return value switch
            {
                "skill_reference" => HostedSkillResourceSkillReferenceType.SkillReference,
                _ => null,
            };
        }
    }
}