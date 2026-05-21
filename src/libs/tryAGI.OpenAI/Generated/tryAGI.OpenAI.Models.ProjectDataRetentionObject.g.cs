
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `project.data_retention`.
    /// </summary>
    public enum ProjectDataRetentionObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectDataRetention,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectDataRetentionObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectDataRetentionObject value)
        {
            return value switch
            {
                ProjectDataRetentionObject.ProjectDataRetention => "project.data_retention",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectDataRetentionObject? ToEnum(string value)
        {
            return value switch
            {
                "project.data_retention" => ProjectDataRetentionObject.ProjectDataRetention,
                _ => null,
            };
        }
    }
}