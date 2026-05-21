
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of user.
    /// </summary>
    public enum GroupMemberUserUserType
    {
        /// <summary>
        /// 
        /// </summary>
        TenantUser,
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class GroupMemberUserUserTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GroupMemberUserUserType value)
        {
            return value switch
            {
                GroupMemberUserUserType.TenantUser => "tenant_user",
                GroupMemberUserUserType.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GroupMemberUserUserType? ToEnum(string value)
        {
            return value switch
            {
                "tenant_user" => GroupMemberUserUserType.TenantUser,
                "user" => GroupMemberUserUserType.User,
                _ => null,
            };
        }
    }
}