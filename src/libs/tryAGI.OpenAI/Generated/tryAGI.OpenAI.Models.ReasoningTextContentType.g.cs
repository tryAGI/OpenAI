
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the reasoning text. Always `reasoning_text`.<br/>
    /// Default Value: reasoning_text
    /// </summary>
    public enum ReasoningTextContentType
    {
        /// <summary>
        /// 
        /// </summary>
        ReasoningText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ReasoningTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ReasoningTextContentType value)
        {
            return value switch
            {
                ReasoningTextContentType.ReasoningText => "reasoning_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ReasoningTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "reasoning_text" => ReasoningTextContentType.ReasoningText,
                _ => null,
            };
        }
    }
}