
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `summary_text`.<br/>
    /// Default Value: summary_text
    /// </summary>
    public enum SummaryTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryTextContentType value)
        {
            return value switch
            {
                SummaryTextContentType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => SummaryTextContentType.SummaryText,
                _ => null,
            };
        }
    }
}