
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum GrammarSyntax1
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
    public static class GrammarSyntax1Extensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this GrammarSyntax1 value)
        {
            return value switch
            {
                GrammarSyntax1.Lark => "lark",
                GrammarSyntax1.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static GrammarSyntax1? ToEnum(string value)
        {
            return value switch
            {
                "lark" => GrammarSyntax1.Lark,
                "regex" => GrammarSyntax1.Regex,
                _ => null,
            };
        }
    }
}