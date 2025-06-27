
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.cancelled`.
    /// </summary>
    public enum WebhookResponseCancelledType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseCancelledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseCancelledType value)
        {
            return value switch
            {
                WebhookResponseCancelledType.ResponseCancelled => "response.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseCancelledType? ToEnum(string value)
        {
            return value switch
            {
                "response.cancelled" => WebhookResponseCancelledType.ResponseCancelled,
                _ => null,
            };
        }
    }
}