
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaContainerAutoParamSkillDiscriminatorType
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
    public static class BetaContainerAutoParamSkillDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaContainerAutoParamSkillDiscriminatorType value)
        {
            return value switch
            {
                BetaContainerAutoParamSkillDiscriminatorType.Inline => "inline",
                BetaContainerAutoParamSkillDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaContainerAutoParamSkillDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => BetaContainerAutoParamSkillDiscriminatorType.Inline,
                "skill_reference" => BetaContainerAutoParamSkillDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}