
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.<br/>
    /// Default Value: list
    /// </summary>
    public enum SkillVersionListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SkillVersionListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SkillVersionListResourceObject value)
        {
            return value switch
            {
                SkillVersionListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SkillVersionListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => SkillVersionListResourceObject.List,
                _ => null,
            };
        }
    }
}