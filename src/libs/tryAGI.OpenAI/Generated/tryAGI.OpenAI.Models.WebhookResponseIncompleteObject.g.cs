
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object of the event. Always `event`.
    /// </summary>
    public enum WebhookResponseIncompleteObject
    {
        /// <summary>
        /// 
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookResponseIncompleteObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookResponseIncompleteObject value)
        {
            return value switch
            {
                WebhookResponseIncompleteObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookResponseIncompleteObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookResponseIncompleteObject.Event,
                _ => null,
            };
        }
    }
}