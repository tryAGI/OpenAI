
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookResponseCancelledObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseCancelledObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseCancelledObject value)
        {
            return value switch
            {
                WebhookResponseCancelledObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseCancelledObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookResponseCancelledObject.Event,
                _ => null,
            };
        }
    }
}