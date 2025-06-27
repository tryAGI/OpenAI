
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookEvalRunFailedObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunFailedObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunFailedObject value)
        {
            return value switch
            {
                WebhookEvalRunFailedObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunFailedObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookEvalRunFailedObject.Event,
                _ => null,
            };
        }
    }
}