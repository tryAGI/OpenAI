
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSessionCreateResponseTransportDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        Sip,
        /// <summary>
        ///
        /// </summary>
        Webrtc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionCreateResponseTransportDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionCreateResponseTransportDiscriminatorType value)
        {
            return value switch
            {
                LiveSessionCreateResponseTransportDiscriminatorType.Sip => "sip",
                LiveSessionCreateResponseTransportDiscriminatorType.Webrtc => "webrtc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionCreateResponseTransportDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip" => LiveSessionCreateResponseTransportDiscriminatorType.Sip,
                "webrtc" => LiveSessionCreateResponseTransportDiscriminatorType.Webrtc,
                _ => null,
            };
        }
    }
}