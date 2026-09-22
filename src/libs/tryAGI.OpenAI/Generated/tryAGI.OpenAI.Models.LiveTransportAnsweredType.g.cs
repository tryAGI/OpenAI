
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: transport.answered
    /// </summary>
    public enum LiveTransportAnsweredType
    {
        /// <summary>
        ///
        /// </summary>
        TransportAnswered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveTransportAnsweredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveTransportAnsweredType value)
        {
            return value switch
            {
                LiveTransportAnsweredType.TransportAnswered => "transport.answered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveTransportAnsweredType? ToEnum(string value)
        {
            return value switch
            {
                "transport.answered" => LiveTransportAnsweredType.TransportAnswered,
                _ => null,
            };
        }
    }
}