
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookBatchCompletedObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchCompletedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchCompletedObject value)
        {
            return value switch
            {
                WebhookBatchCompletedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchCompletedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookBatchCompletedObject.Event,
                _ => null,
            };
        }
    }
}