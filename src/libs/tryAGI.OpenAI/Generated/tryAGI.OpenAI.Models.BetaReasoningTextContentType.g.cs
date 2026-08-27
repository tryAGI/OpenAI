
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the reasoning text. Always `reasoning_text`.<br/>
    /// Default Value: reasoning_text
    /// </summary>
    public enum BetaReasoningTextContentType
    {
        /// <summary>
        ///
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaReasoningTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaReasoningTextContentType value)
        {
            return value switch
            {
                BetaReasoningTextContentType.ReasoningText => "reasoning_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaReasoningTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_text" => BetaReasoningTextContentType.ReasoningText,
                _ => null,
            };
        }
    }
}