
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `event`.
    /// </summary>
    public enum WebhookSafetyOrgAlertCreatedObject
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyOrgAlertCreatedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyOrgAlertCreatedObject value)
        {
            return value switch
            {
                WebhookSafetyOrgAlertCreatedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyOrgAlertCreatedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookSafetyOrgAlertCreatedObject.Event,
                _ => null,
            };
        }
    }
}