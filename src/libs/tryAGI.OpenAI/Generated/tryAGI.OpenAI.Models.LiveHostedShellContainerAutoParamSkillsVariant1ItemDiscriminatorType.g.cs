
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType
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
    public static class LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType.Inline => "inline",
                LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "inline" => LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType.Inline,
                "skill_reference" => LiveHostedShellContainerAutoParamSkillsVariant1ItemDiscriminatorType.SkillReference,
                _ => null,
            };
        }
    }
}