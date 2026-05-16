
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `project.model_permissions.deleted`.
    /// </summary>
    public enum ProjectModelPermissionsDeleteResponseObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectModelPermissionsDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectModelPermissionsDeleteResponseObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectModelPermissionsDeleteResponseObject value)
        {
            return value switch
            {
                ProjectModelPermissionsDeleteResponseObject.ProjectModelPermissionsDeleted => "project.model_permissions.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectModelPermissionsDeleteResponseObject? ToEnum(string value)
        {
            return value switch
            {
                "project.model_permissions.deleted" => ProjectModelPermissionsDeleteResponseObject.ProjectModelPermissionsDeleted,
                _ => null,
            };
        }
    }
}