
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The syntax of the grammar definition. One of `lark` or `regex`.
    /// </summary>
    public enum CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax
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
    public static class CustomToolChatCompletionsCustomFormatVariant2GrammarSyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax value)
        {
            return value switch
            {
                CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax.Lark => "lark",
                CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax? ToEnum(string value)
        {
            return value switch
            {
                "lark" => CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax.Lark,
                "regex" => CustomToolChatCompletionsCustomFormatVariant2GrammarSyntax.Regex,
                _ => null,
            };
        }
    }
}