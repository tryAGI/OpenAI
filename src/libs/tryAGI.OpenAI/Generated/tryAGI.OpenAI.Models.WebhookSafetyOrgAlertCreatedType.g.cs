
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `safety.org_alert.created`.
    /// </summary>
    public enum WebhookSafetyOrgAlertCreatedType
    {
        /// <summary>
        ///
        /// </summary>
        SafetyOrgAlertCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyOrgAlertCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyOrgAlertCreatedType value)
        {
            return value switch
            {
                WebhookSafetyOrgAlertCreatedType.SafetyOrgAlertCreated => "safety.org_alert.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyOrgAlertCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "safety.org_alert.created" => WebhookSafetyOrgAlertCreatedType.SafetyOrgAlertCreated,
                _ => null,
            };
        }
    }
}