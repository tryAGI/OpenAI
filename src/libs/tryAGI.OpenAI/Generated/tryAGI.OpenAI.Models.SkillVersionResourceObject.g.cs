
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is `skill.version`.<br/>
    /// Default Value: skill.version
    /// </summary>
    public enum SkillVersionResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        SkillVersion,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillVersionResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillVersionResourceObject value)
        {
            return value switch
            {
                SkillVersionResourceObject.SkillVersion => "skill.version",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillVersionResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "skill.version" => SkillVersionResourceObject.SkillVersion,
                _ => null,
            };
        }
    }
}