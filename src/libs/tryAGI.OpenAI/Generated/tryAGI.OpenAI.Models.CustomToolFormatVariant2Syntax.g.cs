
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The syntax of the grammar definition. One of `lark` or `regex`.
    /// </summary>
    public enum CustomToolFormatVariant2Syntax
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
    public static class CustomToolFormatVariant2SyntaxExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomToolFormatVariant2Syntax value)
        {
            return value switch
            {
                CustomToolFormatVariant2Syntax.Lark => "lark",
                CustomToolFormatVariant2Syntax.Regex => "regex",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomToolFormatVariant2Syntax? ToEnum(string value)
        {
            return value switch
            {
                "lark" => CustomToolFormatVariant2Syntax.Lark,
                "regex" => CustomToolFormatVariant2Syntax.Regex,
                _ => null,
            };
        }
    }
}