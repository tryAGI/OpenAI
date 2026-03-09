
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `list`.
    /// </summary>
    public enum GroupListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupListResourceObject value)
        {
            return value switch
            {
                GroupListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => GroupListResourceObject.List,
                _ => null,
            };
        }
    }
}