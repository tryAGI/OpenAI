
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaSearchContentType
    {
        /// <summary>
        ///
        /// </summary>
        Image,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaSearchContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaSearchContentType value)
        {
            return value switch
            {
                BetaSearchContentType.Image => "image",
                BetaSearchContentType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaSearchContentType? ToEnum(string value)
        {
            return value switch
            {
                "image" => BetaSearchContentType.Image,
                "text" => BetaSearchContentType.Text,
                _ => null,
            };
        }
    }
}