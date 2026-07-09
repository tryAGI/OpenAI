
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookSafetyIdentifierBlockedObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyIdentifierBlockedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyIdentifierBlockedObject value)
        {
            return value switch
            {
                WebhookSafetyIdentifierBlockedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyIdentifierBlockedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookSafetyIdentifierBlockedObject.Event,
                _ => null,
            };
        }
    }
}