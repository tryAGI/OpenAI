
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: text
    /// </summary>
    public enum BetaTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTextContentType value)
        {
            return value switch
            {
                BetaTextContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaTextContentType.Text,
                _ => null,
            };
        }
    }
}