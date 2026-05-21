
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The time interval for evaluating spend against the threshold.
    /// </summary>
    public enum ProjectSpendAlertInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ProjectSpendAlertIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ProjectSpendAlertInterval value)
        {
            return value switch
            {
                ProjectSpendAlertInterval.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ProjectSpendAlertInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => ProjectSpendAlertInterval.Month,
                _ => null,
            };
        }
    }
}