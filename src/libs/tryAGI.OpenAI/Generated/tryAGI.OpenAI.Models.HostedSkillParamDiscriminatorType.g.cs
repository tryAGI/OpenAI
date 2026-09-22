
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum HostedSkillParamDiscriminatorType
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
    public static class HostedSkillParamDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this HostedSkillParamDiscriminatorType value)
        {
            return value switch
            {
                HostedSkillParamDiscriminatorType.Inline => "inline",
                HostedSkillParamDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static HostedSkillParamDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => HostedSkillParamDiscriminatorType.Inline,
                "skill_reference" => HostedSkillParamDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}