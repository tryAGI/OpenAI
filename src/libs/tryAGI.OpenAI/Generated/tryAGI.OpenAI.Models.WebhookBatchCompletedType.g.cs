
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `batch.completed`.
    /// </summary>
    public enum WebhookBatchCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        BatchCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookBatchCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookBatchCompletedType value)
        {
            return value switch
            {
                WebhookBatchCompletedType.BatchCompleted => "batch.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookBatchCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "batch.completed" => WebhookBatchCompletedType.BatchCompleted,
                _ => null,
            };
        }
    }
}