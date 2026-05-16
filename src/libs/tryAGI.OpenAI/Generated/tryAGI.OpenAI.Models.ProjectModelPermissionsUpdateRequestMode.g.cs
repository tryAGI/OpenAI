
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The model permissions mode to apply.
    /// </summary>
    public enum ProjectModelPermissionsUpdateRequestMode
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
    public static class ProjectModelPermissionsUpdateRequestModeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectModelPermissionsUpdateRequestMode value)
        {
            return value switch
            {
                ProjectModelPermissionsUpdateRequestMode.AllowList => "allow_list",
                ProjectModelPermissionsUpdateRequestMode.DenyList => "deny_list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectModelPermissionsUpdateRequestMode? ToEnum(string value)
        {
            return value switch
            {
                "allow_list" => ProjectModelPermissionsUpdateRequestMode.AllowList,
                "deny_list" => ProjectModelPermissionsUpdateRequestMode.DenyList,
                _ => null,
            };
        }
    }
}