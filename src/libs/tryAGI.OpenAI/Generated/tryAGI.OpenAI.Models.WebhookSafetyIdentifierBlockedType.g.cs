
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `safety_identifier.blocked`.
    /// </summary>
    public enum WebhookSafetyIdentifierBlockedType
    {
        /// <summary>
        /// 
        /// </summary>
        SafetyIdentifierBlocked,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookSafetyIdentifierBlockedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookSafetyIdentifierBlockedType value)
        {
            return value switch
            {
                WebhookSafetyIdentifierBlockedType.SafetyIdentifierBlocked => "safety_identifier.blocked",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookSafetyIdentifierBlockedType? ToEnum(string value)
        {
            return value switch
            {
                "safety_identifier.blocked" => WebhookSafetyIdentifierBlockedType.SafetyIdentifierBlocked,
                _ => null,
            };
        }
    }
}