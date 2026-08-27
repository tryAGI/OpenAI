
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of response format being defined. Always `text`.
    /// </summary>
    public enum BetaResponseFormatTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFormatTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFormatTextType value)
        {
            return value switch
            {
                BetaResponseFormatTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFormatTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaResponseFormatTextType.Text,
                _ => null,
            };
        }
    }
}