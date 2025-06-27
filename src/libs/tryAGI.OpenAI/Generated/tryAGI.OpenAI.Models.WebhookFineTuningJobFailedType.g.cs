
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `fine_tuning.job.failed`.
    /// </summary>
    public enum WebhookFineTuningJobFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningJobFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookFineTuningJobFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookFineTuningJobFailedType value)
        {
            return value switch
            {
                WebhookFineTuningJobFailedType.FineTuningJobFailed => "fine_tuning.job.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookFineTuningJobFailedType? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.failed" => WebhookFineTuningJobFailedType.FineTuningJobFailed,
                _ => null,
            };
        }
    }
}