
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookFineTuningJobCancelledObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookFineTuningJobCancelledObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookFineTuningJobCancelledObject value)
        {
            return value switch
            {
                WebhookFineTuningJobCancelledObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookFineTuningJobCancelledObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookFineTuningJobCancelledObject.Event,
                _ => null,
            };
        }
    }
}