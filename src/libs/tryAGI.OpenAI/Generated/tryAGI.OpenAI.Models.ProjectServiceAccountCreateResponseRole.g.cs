
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Service accounts created with default project membership have role `member`. Accounts created with `create_service_account_only` have role `none`.
    /// </summary>
    public enum ProjectServiceAccountCreateResponseRole
    {
        /// <summary>
        /// 
        /// </summary>
        Member,
        /// <summary>
        /// 
        /// </summary>
        None,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountCreateResponseRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountCreateResponseRole value)
        {
            return value switch
            {
                ProjectServiceAccountCreateResponseRole.Member => "member",
                ProjectServiceAccountCreateResponseRole.None => "none",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountCreateResponseRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ProjectServiceAccountCreateResponseRole.Member,
                "none" => ProjectServiceAccountCreateResponseRole.None,
                _ => null,
            };
        }
    }
}