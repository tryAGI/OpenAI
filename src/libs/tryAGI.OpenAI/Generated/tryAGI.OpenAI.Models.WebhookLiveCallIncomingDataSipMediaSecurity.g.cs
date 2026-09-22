
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum WebhookLiveCallIncomingDataSipMediaSecurity
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
    public static class WebhookLiveCallIncomingDataSipMediaSecurityExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveCallIncomingDataSipMediaSecurity value)
        {
            return value switch
            {
                WebhookLiveCallIncomingDataSipMediaSecurity.Rtp => "rtp",
                WebhookLiveCallIncomingDataSipMediaSecurity.Srtp => "srtp",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveCallIncomingDataSipMediaSecurity? ToEnum(string value)
        {
            return value switch
            {
                "rtp" => WebhookLiveCallIncomingDataSipMediaSecurity.Rtp,
                "srtp" => WebhookLiveCallIncomingDataSipMediaSecurity.Srtp,
                _ => null,
            };
        }
    }
}