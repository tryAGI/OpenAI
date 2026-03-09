
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: skill.version.deleted
    /// </summary>
    public enum DeletedSkillVersionResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        SkillVersionDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedSkillVersionResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedSkillVersionResourceObject value)
        {
            return value switch
            {
                DeletedSkillVersionResourceObject.SkillVersionDeleted => "skill.version.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedSkillVersionResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "skill.version.deleted" => DeletedSkillVersionResourceObject.SkillVersionDeleted,
                _ => null,
            };
        }
    }
}