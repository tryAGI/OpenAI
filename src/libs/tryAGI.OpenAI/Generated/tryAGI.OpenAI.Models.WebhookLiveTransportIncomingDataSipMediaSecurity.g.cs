
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookLiveTransportIncomingDataSipMediaSecurity
    {
        /// <summary>
        ///
        /// </summary>
        Rtp,
        /// <summary>
        ///
        /// </summary>
        Srtp,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveTransportIncomingDataSipMediaSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveTransportIncomingDataSipMediaSecurity value)
        {
            return value switch
            {
                WebhookLiveTransportIncomingDataSipMediaSecurity.Rtp => "rtp",
                WebhookLiveTransportIncomingDataSipMediaSecurity.Srtp => "srtp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveTransportIncomingDataSipMediaSecurity? ToEnum(string value)
        {
            return value switch
            {
                "rtp" => WebhookLiveTransportIncomingDataSipMediaSecurity.Rtp,
                "srtp" => WebhookLiveTransportIncomingDataSipMediaSecurity.Srtp,
                _ => null,
            };
        }
    }
}