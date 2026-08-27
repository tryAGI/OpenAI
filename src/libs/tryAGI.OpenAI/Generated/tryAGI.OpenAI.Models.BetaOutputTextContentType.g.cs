
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output text. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum BetaOutputTextContentType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputTextContentType value)
        {
            return value switch
            {
                BetaOutputTextContentType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => BetaOutputTextContentType.OutputText,
                _ => null,
            };
        }
    }
}