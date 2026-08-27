
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum BetaGrammarSyntax1
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
    public static class BetaGrammarSyntax1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaGrammarSyntax1 value)
        {
            return value switch
            {
                BetaGrammarSyntax1.Lark => "lark",
                BetaGrammarSyntax1.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaGrammarSyntax1? ToEnum(string value)
        {
            return value switch
            {
                "lark" => BetaGrammarSyntax1.Lark,
                "regex" => BetaGrammarSyntax1.Regex,
                _ => null,
            };
        }
    }
}