
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.failed
    /// </summary>
    public enum LiveTransportFailedType
    {
        /// <summary>
        ///
        /// </summary>
        TransportFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportFailedType value)
        {
            return value switch
            {
                LiveTransportFailedType.TransportFailed => "transport.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportFailedType? ToEnum(string value)
        {
            return value switch
            {
                "transport.failed" => LiveTransportFailedType.TransportFailed,
                _ => null,
            };
        }
    }
}