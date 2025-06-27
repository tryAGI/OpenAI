
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `batch.cancelled`.
    /// </summary>
    public enum WebhookBatchCancelledType
    {
        /// <summary>
        /// 
        /// </summary>
        BatchCancelled,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchCancelledTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchCancelledType value)
        {
            return value switch
            {
                WebhookBatchCancelledType.BatchCancelled => "batch.cancelled",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchCancelledType? ToEnum(string value)
        {
            return value switch
            {
                "batch.cancelled" => WebhookBatchCancelledType.BatchCancelled,
                _ => null,
            };
        }
    }
}