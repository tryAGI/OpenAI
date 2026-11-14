
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.dtmf.sent
    /// </summary>
    public enum LiveTransportDTMFSentType
    {
        /// <summary>
        ///
        /// </summary>
        TransportDtmfSent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportDTMFSentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportDTMFSentType value)
        {
            return value switch
            {
                LiveTransportDTMFSentType.TransportDtmfSent => "transport.dtmf.sent",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportDTMFSentType? ToEnum(string value)
        {
            return value switch
            {
                "transport.dtmf.sent" => LiveTransportDTMFSentType.TransportDtmfSent,
                _ => null,
            };
        }
    }
}