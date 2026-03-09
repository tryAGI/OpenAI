
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `list`.
    /// </summary>
    public enum UserListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserListResourceObject value)
        {
            return value switch
            {
                UserListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => UserListResourceObject.List,
                _ => null,
            };
        }
    }
}