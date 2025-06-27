
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `fine_tuning.job.cancelled`.
    /// </summary>
    public enum WebhookFineTuningJobCancelledType
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningJobCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookFineTuningJobCancelledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookFineTuningJobCancelledType value)
        {
            return value switch
            {
                WebhookFineTuningJobCancelledType.FineTuningJobCancelled => "fine_tuning.job.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookFineTuningJobCancelledType? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.cancelled" => WebhookFineTuningJobCancelledType.FineTuningJobCancelled,
                _ => null,
            };
        }
    }
}