
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Always `safety.deactivation_issued`.
    /// </summary>
    public enum WebhookSafetyDeactivationIssuedType
    {
        /// <summary>
        ///
        /// </summary>
        SafetyDeactivationIssued,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyDeactivationIssuedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyDeactivationIssuedType value)
        {
            return value switch
            {
                WebhookSafetyDeactivationIssuedType.SafetyDeactivationIssued => "safety.deactivation_issued",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyDeactivationIssuedType? ToEnum(string value)
        {
            return value switch
            {
                "safety.deactivation_issued" => WebhookSafetyDeactivationIssuedType.SafetyDeactivationIssued,
                _ => null,
            };
        }
    }
}