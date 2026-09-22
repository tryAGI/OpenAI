
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.ringing
    /// </summary>
    public enum LiveTransportRingingType
    {
        /// <summary>
        ///
        /// </summary>
        TransportRinging,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportRingingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportRingingType value)
        {
            return value switch
            {
                LiveTransportRingingType.TransportRinging => "transport.ringing",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportRingingType? ToEnum(string value)
        {
            return value switch
            {
                "transport.ringing" => LiveTransportRingingType.TransportRinging,
                _ => null,
            };
        }
    }
}