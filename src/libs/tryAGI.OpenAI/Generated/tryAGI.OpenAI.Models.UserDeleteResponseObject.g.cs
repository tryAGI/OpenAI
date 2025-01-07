
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        OrganizationUserDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserDeleteResponseObject value)
        {
            return value switch
            {
                UserDeleteResponseObject.OrganizationUserDeleted => "organization.user.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "organization.user.deleted" => UserDeleteResponseObject.OrganizationUserDeleted,
                _ => null,
            };
        }
    }
}