
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.dtmf.send
    /// </summary>
    public enum LiveTransportDTMFSendType
    {
        /// <summary>
        ///
        /// </summary>
        TransportDtmfSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportDTMFSendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportDTMFSendType value)
        {
            return value switch
            {
                LiveTransportDTMFSendType.TransportDtmfSend => "transport.dtmf.send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportDTMFSendType? ToEnum(string value)
        {
            return value switch
            {
                "transport.dtmf.send" => LiveTransportDTMFSendType.TransportDtmfSend,
                _ => null,
            };
        }
    }
}