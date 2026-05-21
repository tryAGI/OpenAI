
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Whether the project uses an allowlist or a denylist.
    /// </summary>
    public enum ProjectModelPermissionsMode
    {
        /// <summary>
        /// 
        /// </summary>
        AllowList,
        /// <summary>
        /// 
        /// </summary>
        DenyList,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectModelPermissionsModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectModelPermissionsMode value)
        {
            return value switch
            {
                ProjectModelPermissionsMode.AllowList => "allow_list",
                ProjectModelPermissionsMode.DenyList => "deny_list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectModelPermissionsMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_list" => ProjectModelPermissionsMode.AllowList,
                "deny_list" => ProjectModelPermissionsMode.DenyList,
                _ => null,
            };
        }
    }
}