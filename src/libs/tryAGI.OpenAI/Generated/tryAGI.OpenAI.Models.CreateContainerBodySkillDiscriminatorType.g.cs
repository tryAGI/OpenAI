
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateContainerBodySkillDiscriminatorType
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
    public static class CreateContainerBodySkillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateContainerBodySkillDiscriminatorType value)
        {
            return value switch
            {
                CreateContainerBodySkillDiscriminatorType.Inline => "inline",
                CreateContainerBodySkillDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateContainerBodySkillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => CreateContainerBodySkillDiscriminatorType.Inline,
                "skill_reference" => CreateContainerBodySkillDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}