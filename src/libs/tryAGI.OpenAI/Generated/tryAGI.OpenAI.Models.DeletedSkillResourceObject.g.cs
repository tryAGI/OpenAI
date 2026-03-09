
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: skill.deleted
    /// </summary>
    public enum DeletedSkillResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        SkillDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedSkillResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedSkillResourceObject value)
        {
            return value switch
            {
                DeletedSkillResourceObject.SkillDeleted => "skill.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedSkillResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "skill.deleted" => DeletedSkillResourceObject.SkillDeleted,
                _ => null,
            };
        }
    }
}