
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: response.input_tokens
    /// </summary>
    public enum TokenCountsResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseInputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TokenCountsResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TokenCountsResourceObject value)
        {
            return value switch
            {
                TokenCountsResourceObject.ResponseInputTokens => "response.input_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TokenCountsResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "response.input_tokens" => TokenCountsResourceObject.ResponseInputTokens,
                _ => null,
            };
        }
    }
}