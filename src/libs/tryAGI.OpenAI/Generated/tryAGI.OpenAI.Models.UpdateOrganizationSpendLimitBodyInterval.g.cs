
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
    /// </summary>
    public enum UpdateOrganizationSpendLimitBodyInterval
    {
        /// <summary>
        ///
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateOrganizationSpendLimitBodyIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateOrganizationSpendLimitBodyInterval value)
        {
            return value switch
            {
                UpdateOrganizationSpendLimitBodyInterval.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateOrganizationSpendLimitBodyInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => UpdateOrganizationSpendLimitBodyInterval.Month,
                _ => null,
            };
        }
    }
}