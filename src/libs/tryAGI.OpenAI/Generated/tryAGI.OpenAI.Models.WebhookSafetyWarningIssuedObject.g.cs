
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `event`.
    /// </summary>
    public enum WebhookSafetyWarningIssuedObject
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyWarningIssuedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyWarningIssuedObject value)
        {
            return value switch
            {
                WebhookSafetyWarningIssuedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyWarningIssuedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookSafetyWarningIssuedObject.Event,
                _ => null,
            };
        }
    }
}