
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of response format being defined. Always `grammar`.
    /// </summary>
    public enum ResponseFormatTextGrammarType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseFormatTextGrammarTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseFormatTextGrammarType value)
        {
            return value switch
            {
                ResponseFormatTextGrammarType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseFormatTextGrammarType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => ResponseFormatTextGrammarType.Grammar,
                _ => null,
            };
        }
    }
}