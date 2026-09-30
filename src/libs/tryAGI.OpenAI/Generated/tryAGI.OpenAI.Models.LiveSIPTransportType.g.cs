
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The transport used for the Live session. Always `sip`.
    /// </summary>
    public enum LiveSIPTransportType
    {
        /// <summary>
        ///
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSIPTransportTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSIPTransportType value)
        {
            return value switch
            {
                LiveSIPTransportType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSIPTransportType? ToEnum(string value)
        {
            return value switch
            {
                "sip" => LiveSIPTransportType.Sip,
                _ => null,
            };
        }
    }
}