
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: content
    /// </summary>
    public enum LiveSessionClosedReasonVariant3
    {
        /// <summary>
        ///
        /// </summary>
        Content,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionClosedReasonVariant3Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionClosedReasonVariant3 value)
        {
            return value switch
            {
                LiveSessionClosedReasonVariant3.Content => "content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionClosedReasonVariant3? ToEnum(string value)
        {
            return value switch
            {
                "content" => LiveSessionClosedReasonVariant3.Content,
                _ => null,
            };
        }
    }
}