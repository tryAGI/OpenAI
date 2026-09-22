
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `event`.
    /// </summary>
    public enum WebhookSafetyAlertCreatedObject
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyAlertCreatedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyAlertCreatedObject value)
        {
            return value switch
            {
                WebhookSafetyAlertCreatedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyAlertCreatedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookSafetyAlertCreatedObject.Event,
                _ => null,
            };
        }
    }
}