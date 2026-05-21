
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The time interval for evaluating spend against the threshold.
    /// </summary>
    public enum CreateSpendAlertBodyInterval
    {
        /// <summary>
        /// 
        /// </summary>
        Month,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpendAlertBodyIntervalExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpendAlertBodyInterval value)
        {
            return value switch
            {
                CreateSpendAlertBodyInterval.Month => "month",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpendAlertBodyInterval? ToEnum(string value)
        {
            return value switch
            {
                "month" => CreateSpendAlertBodyInterval.Month,
                _ => null,
            };
        }
    }
}