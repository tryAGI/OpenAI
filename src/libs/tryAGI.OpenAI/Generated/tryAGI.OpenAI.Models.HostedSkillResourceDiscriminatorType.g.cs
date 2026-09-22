
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedSkillResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Inline,
        /// <summary>
        ///
        /// </summary>
        SkillReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class HostedSkillResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedSkillResourceDiscriminatorType value)
        {
            return value switch
            {
                HostedSkillResourceDiscriminatorType.Inline => "inline",
                HostedSkillResourceDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedSkillResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedSkillResourceDiscriminatorType.Inline,
                "skill_reference" => HostedSkillResourceDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}