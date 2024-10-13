
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The name of the rate limit.<br/>
    /// Example: requests
    /// </summary>
    public enum RealtimeRateLimitsUpdatedRateLimitName
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
        /// <summary>
        /// 
        /// </summary>
        InputTokens,
        /// <summary>
        /// 
        /// </summary>
        OutputTokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeRateLimitsUpdatedRateLimitNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeRateLimitsUpdatedRateLimitName value)
        {
            return value switch
            {
                RealtimeRateLimitsUpdatedRateLimitName.Requests => "requests",
                RealtimeRateLimitsUpdatedRateLimitName.Tokens => "tokens",
                RealtimeRateLimitsUpdatedRateLimitName.InputTokens => "input_tokens",
                RealtimeRateLimitsUpdatedRateLimitName.OutputTokens => "output_tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeRateLimitsUpdatedRateLimitName? ToEnum(string value)
        {
            return value switch
            {
                "requests" => RealtimeRateLimitsUpdatedRateLimitName.Requests,
                "tokens" => RealtimeRateLimitsUpdatedRateLimitName.Tokens,
                "input_tokens" => RealtimeRateLimitsUpdatedRateLimitName.InputTokens,
                "output_tokens" => RealtimeRateLimitsUpdatedRateLimitName.OutputTokens,
                _ => null,
            };
        }
    }
}