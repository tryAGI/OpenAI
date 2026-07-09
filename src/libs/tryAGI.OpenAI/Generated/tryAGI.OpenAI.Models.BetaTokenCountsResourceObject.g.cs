
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: response.input_tokens
    /// </summary>
    public enum BetaTokenCountsResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseInputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaTokenCountsResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaTokenCountsResourceObject value)
        {
            return value switch
            {
                BetaTokenCountsResourceObject.ResponseInputTokens => "response.input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaTokenCountsResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "response.input_tokens" => BetaTokenCountsResourceObject.ResponseInputTokens,
                _ => null,
            };
        }
    }
}