
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.dtmf.send
    /// </summary>
    public enum LiveTransportDTMFSendParamType
    {
        /// <summary>
        ///
        /// </summary>
        TransportDtmfSend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportDTMFSendParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportDTMFSendParamType value)
        {
            return value switch
            {
                LiveTransportDTMFSendParamType.TransportDtmfSend => "transport.dtmf.send",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportDTMFSendParamType? ToEnum(string value)
        {
            return value switch
            {
                "transport.dtmf.send" => LiveTransportDTMFSendParamType.TransportDtmfSend,
                _ => null,
            };
        }
    }
}