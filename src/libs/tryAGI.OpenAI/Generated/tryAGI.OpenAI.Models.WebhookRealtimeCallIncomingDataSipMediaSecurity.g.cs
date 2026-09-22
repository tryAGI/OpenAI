
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookRealtimeCallIncomingDataSipMediaSecurity
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
    public static class WebhookRealtimeCallIncomingDataSipMediaSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRealtimeCallIncomingDataSipMediaSecurity value)
        {
            return value switch
            {
                WebhookRealtimeCallIncomingDataSipMediaSecurity.Rtp => "rtp",
                WebhookRealtimeCallIncomingDataSipMediaSecurity.Srtp => "srtp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRealtimeCallIncomingDataSipMediaSecurity? ToEnum(string value)
        {
            return value switch
            {
                "rtp" => WebhookRealtimeCallIncomingDataSipMediaSecurity.Rtp,
                "srtp" => WebhookRealtimeCallIncomingDataSipMediaSecurity.Srtp,
                _ => null,
            };
        }
    }
}