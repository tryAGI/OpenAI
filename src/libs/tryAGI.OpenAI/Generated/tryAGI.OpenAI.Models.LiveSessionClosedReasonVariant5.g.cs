
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: connection_lost
    /// </summary>
    public enum LiveSessionClosedReasonVariant5
    {
        /// <summary>
        ///
        /// </summary>
        ConnectionLost,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedReasonVariant5Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedReasonVariant5 value)
        {
            return value switch
            {
                LiveSessionClosedReasonVariant5.ConnectionLost => "connection_lost",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedReasonVariant5? ToEnum(string value)
        {
            return value switch
            {
                "connection_lost" => LiveSessionClosedReasonVariant5.ConnectionLost,
                _ => null,
            };
        }
    }
}