
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: expired
    /// </summary>
    public enum LiveSessionClosedReasonVariant2
    {
        /// <summary>
        ///
        /// </summary>
        Expired,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedReasonVariant2Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedReasonVariant2 value)
        {
            return value switch
            {
                LiveSessionClosedReasonVariant2.Expired => "expired",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedReasonVariant2? ToEnum(string value)
        {
            return value switch
            {
                "expired" => LiveSessionClosedReasonVariant2.Expired,
                _ => null,
            };
        }
    }
}