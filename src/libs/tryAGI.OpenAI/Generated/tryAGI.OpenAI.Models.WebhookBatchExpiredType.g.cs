
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `batch.expired`.
    /// </summary>
    public enum WebhookBatchExpiredType
    {
        /// <summary>
        /// 
        /// </summary>
        BatchExpired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchExpiredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchExpiredType value)
        {
            return value switch
            {
                WebhookBatchExpiredType.BatchExpired => "batch.expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchExpiredType? ToEnum(string value)
        {
            return value switch
            {
                "batch.expired" => WebhookBatchExpiredType.BatchExpired,
                _ => null,
            };
        }
    }
}