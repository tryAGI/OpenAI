
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ContainerAutoParamSkillDiscriminatorType
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
    public static class ContainerAutoParamSkillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ContainerAutoParamSkillDiscriminatorType value)
        {
            return value switch
            {
                ContainerAutoParamSkillDiscriminatorType.Inline => "inline",
                ContainerAutoParamSkillDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ContainerAutoParamSkillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => ContainerAutoParamSkillDiscriminatorType.Inline,
                "skill_reference" => ContainerAutoParamSkillDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}