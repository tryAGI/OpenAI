
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `user.role`.
    /// </summary>
    public enum UserRoleAssignmentObject
    {
        /// <summary>
        /// 
        /// </summary>
        UserRole,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserRoleAssignmentObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserRoleAssignmentObject value)
        {
            return value switch
            {
                UserRoleAssignmentObject.UserRole => "user.role",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserRoleAssignmentObject? ToEnum(string value)
        {
            return value switch
            {
                "user.role" => UserRoleAssignmentObject.UserRole,
                _ => null,
            };
        }
    }
}