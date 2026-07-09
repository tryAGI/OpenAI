
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// References a skill created with the /v1/skills endpoint.<br/>
    /// Default Value: skill_reference
    /// </summary>
    public enum BetaSkillReferenceParamType
    {
        /// <summary>
        /// 
        /// </summary>
        SkillReference,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSkillReferenceParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSkillReferenceParamType value)
        {
            return value switch
            {
                BetaSkillReferenceParamType.SkillReference => "skill_reference",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSkillReferenceParamType? ToEnum(string value)
        {
            return value switch
            {
                "skill_reference" => BetaSkillReferenceParamType.SkillReference,
                _ => null,
            };
        }
    }
}