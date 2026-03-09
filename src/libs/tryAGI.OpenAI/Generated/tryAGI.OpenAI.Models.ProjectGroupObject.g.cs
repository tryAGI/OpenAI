
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `project.group`.
    /// </summary>
    public enum ProjectGroupObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectGroup,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectGroupObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectGroupObject value)
        {
            return value switch
            {
                ProjectGroupObject.ProjectGroup => "project.group",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectGroupObject? ToEnum(string value)
        {
            return value switch
            {
                "project.group" => ProjectGroupObject.ProjectGroup,
                _ => null,
            };
        }
    }
}