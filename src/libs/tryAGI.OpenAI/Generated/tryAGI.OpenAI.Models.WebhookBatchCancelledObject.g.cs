
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookBatchCancelledObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchCancelledObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchCancelledObject value)
        {
            return value switch
            {
                WebhookBatchCancelledObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchCancelledObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookBatchCancelledObject.Event,
                _ => null,
            };
        }
    }
}