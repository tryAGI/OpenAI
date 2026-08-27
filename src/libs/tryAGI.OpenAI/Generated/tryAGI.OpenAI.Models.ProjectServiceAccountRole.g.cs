
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// `owner`, `member`, or `none`
    /// </summary>
    public enum ProjectServiceAccountRole
    {
        /// <summary>
        ///
        /// </summary>
        Member,
        /// <summary>
        ///
        /// </summary>
        None,
        /// <summary>
        ///
        /// </summary>
        Owner,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectServiceAccountRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectServiceAccountRole value)
        {
            return value switch
            {
                ProjectServiceAccountRole.Member => "member",
                ProjectServiceAccountRole.None => "none",
                ProjectServiceAccountRole.Owner => "owner",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectServiceAccountRole? ToEnum(string value)
        {
            return value switch
            {
                "member" => ProjectServiceAccountRole.Member,
                "none" => ProjectServiceAccountRole.None,
                "owner" => ProjectServiceAccountRole.Owner,
                _ => null,
            };
        }
    }
}