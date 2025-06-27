
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.completed`.
    /// </summary>
    public enum WebhookResponseCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseCompletedType value)
        {
            return value switch
            {
                WebhookResponseCompletedType.ResponseCompleted => "response.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "response.completed" => WebhookResponseCompletedType.ResponseCompleted,
                _ => null,
            };
        }
    }
}