
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.dtmf.received
    /// </summary>
    public enum LiveTransportDTMFReceivedType
    {
        /// <summary>
        ///
        /// </summary>
        TransportDtmfReceived,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportDTMFReceivedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportDTMFReceivedType value)
        {
            return value switch
            {
                LiveTransportDTMFReceivedType.TransportDtmfReceived => "transport.dtmf.received",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportDTMFReceivedType? ToEnum(string value)
        {
            return value switch
            {
                "transport.dtmf.received" => LiveTransportDTMFReceivedType.TransportDtmfReceived,
                _ => null,
            };
        }
    }
}