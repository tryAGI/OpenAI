
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookRealtimeCallIncomingObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRealtimeCallIncomingObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRealtimeCallIncomingObject value)
        {
            return value switch
            {
                WebhookRealtimeCallIncomingObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRealtimeCallIncomingObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookRealtimeCallIncomingObject.Event,
                _ => null,
            };
        }
    }
}