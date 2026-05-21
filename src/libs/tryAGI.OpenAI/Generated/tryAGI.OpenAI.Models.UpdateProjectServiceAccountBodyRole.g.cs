
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The updated service account role.
    /// </summary>
    public enum UpdateProjectServiceAccountBodyRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectServiceAccountBodyRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectServiceAccountBodyRole value)
        {
            return value switch
            {
                UpdateProjectServiceAccountBodyRole.Member => "member",
                UpdateProjectServiceAccountBodyRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectServiceAccountBodyRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => UpdateProjectServiceAccountBodyRole.Member,
                "owner" => UpdateProjectServiceAccountBodyRole.Owner,
                _ => null,
            };
        }
    }
}