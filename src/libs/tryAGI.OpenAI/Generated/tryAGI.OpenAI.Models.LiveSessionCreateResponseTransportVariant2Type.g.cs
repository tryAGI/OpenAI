
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The transport used for the Live session. Always `sip`.
    /// </summary>
    public enum LiveSessionCreateResponseTransportVariant2Type
    {
        /// <summary>
        ///
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionCreateResponseTransportVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionCreateResponseTransportVariant2Type value)
        {
            return value switch
            {
                LiveSessionCreateResponseTransportVariant2Type.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionCreateResponseTransportVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "sip" => LiveSessionCreateResponseTransportVariant2Type.Sip,
                _ => null,
            };
        }
    }
}