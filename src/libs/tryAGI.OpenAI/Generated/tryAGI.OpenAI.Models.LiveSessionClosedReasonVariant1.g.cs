
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: close_requested
    /// </summary>
    public enum LiveSessionClosedReasonVariant1
    {
        /// <summary>
        ///
        /// </summary>
        CloseRequested,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedReasonVariant1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedReasonVariant1 value)
        {
            return value switch
            {
                LiveSessionClosedReasonVariant1.CloseRequested => "close_requested",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedReasonVariant1? ToEnum(string value)
        {
            return value switch
            {
                "close_requested" => LiveSessionClosedReasonVariant1.CloseRequested,
                _ => null,
            };
        }
    }
}