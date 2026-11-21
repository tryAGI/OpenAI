
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The session transport.
    /// </summary>
    public enum WebhookLiveTransportConnectedDataType
    {
        /// <summary>
        ///
        /// </summary>
        Webrtc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveTransportConnectedDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveTransportConnectedDataType value)
        {
            return value switch
            {
                WebhookLiveTransportConnectedDataType.Webrtc => "webrtc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveTransportConnectedDataType? ToEnum(string value)
        {
            return value switch
            {
                "webrtc" => WebhookLiveTransportConnectedDataType.Webrtc,
                _ => null,
            };
        }
    }
}