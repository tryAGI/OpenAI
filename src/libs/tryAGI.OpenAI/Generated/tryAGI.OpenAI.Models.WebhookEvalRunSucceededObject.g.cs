
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookEvalRunSucceededObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunSucceededObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunSucceededObject value)
        {
            return value switch
            {
                WebhookEvalRunSucceededObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunSucceededObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookEvalRunSucceededObject.Event,
                _ => null,
            };
        }
    }
}