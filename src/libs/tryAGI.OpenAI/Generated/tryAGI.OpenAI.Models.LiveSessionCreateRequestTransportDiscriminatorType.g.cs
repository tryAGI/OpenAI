
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveSessionCreateRequestTransportDiscriminatorType
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
    public static class LiveSessionCreateRequestTransportDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionCreateRequestTransportDiscriminatorType value)
        {
            return value switch
            {
                LiveSessionCreateRequestTransportDiscriminatorType.Sip => "sip",
                LiveSessionCreateRequestTransportDiscriminatorType.Webrtc => "webrtc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionCreateRequestTransportDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "sip" => LiveSessionCreateRequestTransportDiscriminatorType.Sip,
                "webrtc" => LiveSessionCreateRequestTransportDiscriminatorType.Webrtc,
                _ => null,
            };
        }
    }
}