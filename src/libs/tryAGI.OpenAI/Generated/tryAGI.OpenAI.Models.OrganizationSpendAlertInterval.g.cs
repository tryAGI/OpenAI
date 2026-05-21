
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The time interval for evaluating spend against the threshold.
    /// </summary>
    public enum OrganizationSpendAlertInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class OrganizationSpendAlertIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this OrganizationSpendAlertInterval value)
        {
            return value switch
            {
                OrganizationSpendAlertInterval.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static OrganizationSpendAlertInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => OrganizationSpendAlertInterval.Month,
                _ => null,
            };
        }
    }
}