
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `safety.warning_issued`.
    /// </summary>
    public enum WebhookSafetyWarningIssuedType
    {
        /// <summary>
        ///
        /// </summary>
        SafetyWarningIssued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyWarningIssuedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyWarningIssuedType value)
        {
            return value switch
            {
                WebhookSafetyWarningIssuedType.SafetyWarningIssued => "safety.warning_issued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyWarningIssuedType? ToEnum(string value)
        {
            return value switch
            {
                "safety.warning_issued" => WebhookSafetyWarningIssuedType.SafetyWarningIssued,
                _ => null,
            };
        }
    }
}