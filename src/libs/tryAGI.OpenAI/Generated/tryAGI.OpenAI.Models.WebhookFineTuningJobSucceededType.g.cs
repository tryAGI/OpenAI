
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `fine_tuning.job.succeeded`.
    /// </summary>
    public enum WebhookFineTuningJobSucceededType
    {
        /// <summary>
        /// 
        /// </summary>
        FineTuningJobSucceeded,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookFineTuningJobSucceededTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookFineTuningJobSucceededType value)
        {
            return value switch
            {
                WebhookFineTuningJobSucceededType.FineTuningJobSucceeded => "fine_tuning.job.succeeded",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookFineTuningJobSucceededType? ToEnum(string value)
        {
            return value switch
            {
                "fine_tuning.job.succeeded" => WebhookFineTuningJobSucceededType.FineTuningJobSucceeded,
                _ => null,
            };
        }
    }
}