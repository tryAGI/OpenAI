
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedTemplateSkillResourceDiscriminatorType
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
    public static class HostedTemplateSkillResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedTemplateSkillResourceDiscriminatorType value)
        {
            return value switch
            {
                HostedTemplateSkillResourceDiscriminatorType.Inline => "inline",
                HostedTemplateSkillResourceDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedTemplateSkillResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedTemplateSkillResourceDiscriminatorType.Inline,
                "skill_reference" => HostedTemplateSkillResourceDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}