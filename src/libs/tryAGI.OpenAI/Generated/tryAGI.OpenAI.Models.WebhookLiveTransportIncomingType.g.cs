
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `live.transport.incoming`.
    /// </summary>
    public enum WebhookLiveTransportIncomingType
    {
        /// <summary>
        ///
        /// </summary>
        LiveTransportIncoming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveTransportIncomingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveTransportIncomingType value)
        {
            return value switch
            {
                WebhookLiveTransportIncomingType.LiveTransportIncoming => "live.transport.incoming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveTransportIncomingType? ToEnum(string value)
        {
            return value switch
            {
                "live.transport.incoming" => WebhookLiveTransportIncomingType.LiveTransportIncoming,
                _ => null,
            };
        }
    }
}