
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum BetaCustomToolParamFormatDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Grammar,
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomToolParamFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomToolParamFormatDiscriminatorType value)
        {
            return value switch
            {
                BetaCustomToolParamFormatDiscriminatorType.Grammar => "grammar",
                BetaCustomToolParamFormatDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomToolParamFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "grammar" => BetaCustomToolParamFormatDiscriminatorType.Grammar,
                "text" => BetaCustomToolParamFormatDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}