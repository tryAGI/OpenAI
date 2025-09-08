
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The name of the rate limit (`requests`, `tokens`).
    /// </summary>
    public enum RealtimeBetaServerEventRateLimitsUpdatedRateLimitName
    {
        /// <summary>
        /// 
        /// </summary>
        Requests,
        /// <summary>
        /// 
        /// </summary>
        Tokens,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventRateLimitsUpdatedRateLimitNameExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventRateLimitsUpdatedRateLimitName value)
        {
            return value switch
            {
                RealtimeBetaServerEventRateLimitsUpdatedRateLimitName.Requests => "requests",
                RealtimeBetaServerEventRateLimitsUpdatedRateLimitName.Tokens => "tokens",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventRateLimitsUpdatedRateLimitName? ToEnum(string value)
        {
            return value switch
            {
                "requests" => RealtimeBetaServerEventRateLimitsUpdatedRateLimitName.Requests,
                "tokens" => RealtimeBetaServerEventRateLimitsUpdatedRateLimitName.Tokens,
                _ => null,
            };
        }
    }
}