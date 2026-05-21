
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `project.spend_alert`.
    /// </summary>
    public enum ProjectSpendAlertObject
    {
        /// <summary>
        /// 
        /// </summary>
        ProjectSpendAlert,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendAlertObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendAlertObject value)
        {
            return value switch
            {
                ProjectSpendAlertObject.ProjectSpendAlert => "project.spend_alert",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendAlertObject? ToEnum(string value)
        {
            return value switch
            {
                "project.spend_alert" => ProjectSpendAlertObject.ProjectSpendAlert,
                _ => null,
            };
        }
    }
}