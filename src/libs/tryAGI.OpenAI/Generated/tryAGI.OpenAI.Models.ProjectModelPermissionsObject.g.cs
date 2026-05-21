
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `project.model_permissions`.
    /// </summary>
    public enum ProjectModelPermissionsObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectModelPermissions,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectModelPermissionsObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectModelPermissionsObject value)
        {
            return value switch
            {
                ProjectModelPermissionsObject.ProjectModelPermissions => "project.model_permissions",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectModelPermissionsObject? ToEnum(string value)
        {
            return value switch
            {
                "project.model_permissions" => ProjectModelPermissionsObject.ProjectModelPermissions,
                _ => null,
            };
        }
    }
}