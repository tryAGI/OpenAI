
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `batch.failed`.
    /// </summary>
    public enum WebhookBatchFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        BatchFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchFailedType value)
        {
            return value switch
            {
                WebhookBatchFailedType.BatchFailed => "batch.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchFailedType? ToEnum(string value)
        {
            return value switch
            {
                "batch.failed" => WebhookBatchFailedType.BatchFailed,
                _ => null,
            };
        }
    }
}