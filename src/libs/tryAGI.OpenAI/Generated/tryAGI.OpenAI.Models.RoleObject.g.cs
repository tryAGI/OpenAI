
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `role`.
    /// </summary>
    public enum RoleObject
    {
        /// <summary>
        /// 
        /// </summary>
        Role,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RoleObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RoleObject value)
        {
            return value switch
            {
                RoleObject.Role => "role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RoleObject? ToEnum(string value)
        {
            return value switch
            {
                "role" => RoleObject.Role,
                _ => null,
            };
        }
    }
}