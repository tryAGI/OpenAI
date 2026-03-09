
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The syntax of the grammar definition. One of `lark` or `regex`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax
    {
        /// <summary>
        /// 
        /// </summary>
        Lark,
        /// <summary>
        /// 
        /// </summary>
        Regex,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax.Lark => "lark",
                CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax? ToEnum(string value)
        {
            return value switch
            {
                "lark" => CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax.Lark,
                "regex" => CustomToolChatCompletionsCustomFormatGrammarFormatGrammarSyntax.Regex,
                _ => null,
            };
        }
    }
}