
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `rate_limits.updated`.
    /// </summary>
    public enum RealtimeBetaServerEventRateLimitsUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventRateLimitsUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventRateLimitsUpdatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventRateLimitsUpdatedType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventRateLimitsUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limits.updated" => RealtimeBetaServerEventRateLimitsUpdatedType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}