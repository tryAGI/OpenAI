
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookEvalRunCanceledObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEvalRunCanceledObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEvalRunCanceledObject value)
        {
            return value switch
            {
                WebhookEvalRunCanceledObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEvalRunCanceledObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookEvalRunCanceledObject.Event,
                _ => null,
            };
        }
    }
}