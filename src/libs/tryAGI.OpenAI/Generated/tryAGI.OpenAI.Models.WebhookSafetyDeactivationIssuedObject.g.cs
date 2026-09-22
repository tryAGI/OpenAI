
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `event`.
    /// </summary>
    public enum WebhookSafetyDeactivationIssuedObject
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyDeactivationIssuedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyDeactivationIssuedObject value)
        {
            return value switch
            {
                WebhookSafetyDeactivationIssuedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyDeactivationIssuedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookSafetyDeactivationIssuedObject.Event,
                _ => null,
            };
        }
    }
}