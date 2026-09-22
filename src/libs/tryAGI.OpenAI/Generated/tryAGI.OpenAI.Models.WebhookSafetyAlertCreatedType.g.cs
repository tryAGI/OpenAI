
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `safety.alert.created`.
    /// </summary>
    public enum WebhookSafetyAlertCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        SafetyAlertCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyAlertCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyAlertCreatedType value)
        {
            return value switch
            {
                WebhookSafetyAlertCreatedType.SafetyAlertCreated => "safety.alert.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyAlertCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "safety.alert.created" => WebhookSafetyAlertCreatedType.SafetyAlertCreated,
                _ => null,
            };
        }
    }
}