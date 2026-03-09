
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum SkillListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillListResourceObject value)
        {
            return value switch
            {
                SkillListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => SkillListResourceObject.List,
                _ => null,
            };
        }
    }
}