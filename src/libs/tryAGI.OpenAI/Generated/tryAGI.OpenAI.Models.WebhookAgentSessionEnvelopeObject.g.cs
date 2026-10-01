
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type. Always `event`.
    /// </summary>
    public enum WebhookAgentSessionEnvelopeObject
    {
        /// <summary>
        ///
        /// </summary>
        Event,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookAgentSessionEnvelopeObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookAgentSessionEnvelopeObject value)
        {
            return value switch
            {
                WebhookAgentSessionEnvelopeObject.Event => "event",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookAgentSessionEnvelopeObject? ToEnum(string value)
        {
            return value switch
            {
                "event" => WebhookAgentSessionEnvelopeObject.Event,
                _ => null,
            };
        }
    }
}