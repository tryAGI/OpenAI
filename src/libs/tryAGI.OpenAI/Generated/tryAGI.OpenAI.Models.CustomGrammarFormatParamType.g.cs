
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Grammar format. Always `grammar`.<br/>
    /// Default Value: grammar
    /// </summary>
    public enum CustomGrammarFormatParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CustomGrammarFormatParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CustomGrammarFormatParamType value)
        {
            return value switch
            {
                CustomGrammarFormatParamType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CustomGrammarFormatParamType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => CustomGrammarFormatParamType.Grammar,
                _ => null,
            };
        }
    }
}