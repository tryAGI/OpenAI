
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeBetaResponseCreateParamsMaxOutputTokens
    {
        /// <summary>
        /// 
        /// </summary>
        Inf,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseCreateParamsMaxOutputTokensExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseCreateParamsMaxOutputTokens value)
        {
            return value switch
            {
                RealtimeBetaResponseCreateParamsMaxOutputTokens.Inf => "inf",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseCreateParamsMaxOutputTokens? ToEnum(string value)
        {
            return value switch
            {
                "inf" => RealtimeBetaResponseCreateParamsMaxOutputTokens.Inf,
                _ => null,
            };
        }
    }
}