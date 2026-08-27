
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `project.spend_limit.deleted`.<br/>
    /// Default Value: project.spend_limit.deleted
    /// </summary>
    public enum ProjectSpendLimitDeletedResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        ProjectSpendLimitDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendLimitDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendLimitDeletedResourceObject value)
        {
            return value switch
            {
                ProjectSpendLimitDeletedResourceObject.ProjectSpendLimitDeleted => "project.spend_limit.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendLimitDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "project.spend_limit.deleted" => ProjectSpendLimitDeletedResourceObject.ProjectSpendLimitDeleted,
                _ => null,
            };
        }
    }
}