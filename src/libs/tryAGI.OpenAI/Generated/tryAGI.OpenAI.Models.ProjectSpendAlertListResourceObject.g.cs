
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `list`.
    /// </summary>
    public enum ProjectSpendAlertListResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendAlertListResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendAlertListResourceObject value)
        {
            return value switch
            {
                ProjectSpendAlertListResourceObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendAlertListResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ProjectSpendAlertListResourceObject.List,
                _ => null,
            };
        }
    }
}