
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `project.group.deleted`.
    /// </summary>
    public enum ProjectGroupDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectGroupDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectGroupDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGroupDeletedResourceObject value)
        {
            return value switch
            {
                ProjectGroupDeletedResourceObject.ProjectGroupDeleted => "project.group.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGroupDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "project.group.deleted" => ProjectGroupDeletedResourceObject.ProjectGroupDeleted,
                _ => null,
            };
        }
    }
}