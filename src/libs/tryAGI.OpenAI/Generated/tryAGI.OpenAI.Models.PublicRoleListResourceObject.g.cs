
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `list`.
    /// </summary>
    public enum PublicRoleListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class PublicRoleListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this PublicRoleListResourceObject value)
        {
            return value switch
            {
                PublicRoleListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static PublicRoleListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => PublicRoleListResourceObject.List,
                _ => null,
            };
        }
    }
}