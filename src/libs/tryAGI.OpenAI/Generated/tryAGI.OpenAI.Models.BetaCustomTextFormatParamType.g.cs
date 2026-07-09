
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Unconstrained text format. Always `text`.<br/>
    /// Default Value: text
    /// </summary>
    public enum BetaCustomTextFormatParamType
    {
        /// <summary>
        /// 
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaCustomTextFormatParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaCustomTextFormatParamType value)
        {
            return value switch
            {
                BetaCustomTextFormatParamType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaCustomTextFormatParamType? ToEnum(string value)
        {
            return value switch
            {
                "text" => BetaCustomTextFormatParamType.Text,
                _ => null,
            };
        }
    }
}