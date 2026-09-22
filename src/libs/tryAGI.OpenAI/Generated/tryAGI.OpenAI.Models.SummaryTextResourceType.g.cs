
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `summary_text`.<br/>
    /// Default Value: summary_text
    /// </summary>
    public enum SummaryTextResourceType
    {
        /// <summary>
        ///
        /// </summary>
        SummaryText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class SummaryTextResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this SummaryTextResourceType value)
        {
            return value switch
            {
                SummaryTextResourceType.SummaryText => "summary_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static SummaryTextResourceType? ToEnum(string value)
        {
            return value switch
            {
                "summary_text" => SummaryTextResourceType.SummaryText,
                _ => null,
            };
        }
    }
}