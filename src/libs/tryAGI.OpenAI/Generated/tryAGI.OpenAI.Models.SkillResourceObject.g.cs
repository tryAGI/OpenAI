
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is `skill`.<br/>
    /// Default Value: skill
    /// </summary>
    public enum SkillResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        Skill,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillResourceObject value)
        {
            return value switch
            {
                SkillResourceObject.Skill => "skill",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "skill" => SkillResourceObject.Skill,
                _ => null,
            };
        }
    }
}