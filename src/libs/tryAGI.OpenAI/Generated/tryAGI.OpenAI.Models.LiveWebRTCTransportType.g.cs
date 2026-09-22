
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The transport used for the Live session. Always `webrtc`.
    /// </summary>
    public enum LiveWebRTCTransportType
    {
        /// <summary>
        ///
        /// </summary>
        Webrtc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveWebRTCTransportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveWebRTCTransportType value)
        {
            return value switch
            {
                LiveWebRTCTransportType.Webrtc => "webrtc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveWebRTCTransportType? ToEnum(string value)
        {
            return value switch
            {
                "webrtc" => LiveWebRTCTransportType.Webrtc,
                _ => null,
            };
        }
    }
}