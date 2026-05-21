
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `project.spend_alert.deleted`.
    /// </summary>
    public enum ProjectSpendAlertDeletedResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectSpendAlertDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendAlertDeletedResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendAlertDeletedResourceObject value)
        {
            return value switch
            {
                ProjectSpendAlertDeletedResourceObject.ProjectSpendAlertDeleted => "project.spend_alert.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendAlertDeletedResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "project.spend_alert.deleted" => ProjectSpendAlertDeletedResourceObject.ProjectSpendAlertDeleted,
                _ => null,
            };
        }
    }
}