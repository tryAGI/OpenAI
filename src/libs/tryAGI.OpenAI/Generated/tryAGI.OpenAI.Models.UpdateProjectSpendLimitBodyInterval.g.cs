
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The time interval for evaluating spend against the threshold. Currently, only `month` is supported.
    /// </summary>
    public enum UpdateProjectSpendLimitBodyInterval
    {
        /// <summary>
        ///
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UpdateProjectSpendLimitBodyIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UpdateProjectSpendLimitBodyInterval value)
        {
            return value switch
            {
                UpdateProjectSpendLimitBodyInterval.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UpdateProjectSpendLimitBodyInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => UpdateProjectSpendLimitBodyInterval.Month,
                _ => null,
            };
        }
    }
}