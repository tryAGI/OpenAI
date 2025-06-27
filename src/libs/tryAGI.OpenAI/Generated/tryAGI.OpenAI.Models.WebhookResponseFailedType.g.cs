
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.failed`.
    /// </summary>
    public enum WebhookResponseFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseFailedType value)
        {
            return value switch
            {
                WebhookResponseFailedType.ResponseFailed => "response.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseFailedType? ToEnum(string value)
        {
            return value switch
            {
                "response.failed" => WebhookResponseFailedType.ResponseFailed,
                _ => null,
            };
        }
    }
}