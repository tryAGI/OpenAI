
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Grammar format. Always `grammar`.<br/>
    /// Default Value: grammar
    /// </summary>
    public enum BetaCustomGrammarFormatParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomGrammarFormatParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomGrammarFormatParamType value)
        {
            return value switch
            {
                BetaCustomGrammarFormatParamType.Grammar => "grammar",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomGrammarFormatParamType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => BetaCustomGrammarFormatParamType.Grammar,
                _ => null,
            };
        }
    }
}