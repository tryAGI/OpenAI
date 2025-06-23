
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the usage object. Always `tokens` for this variant.
    /// </summary>
    public enum TranscriptTextUsageTokensType
    {
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TranscriptTextUsageTokensTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TranscriptTextUsageTokensType value)
        {
            return value switch
            {
                TranscriptTextUsageTokensType.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TranscriptTextUsageTokensType? ToEnum(string value)
        {
            return value switch
            {
                "tokens" => TranscriptTextUsageTokensType.Tokens,
                _ => null,
            };
        }
    }
}