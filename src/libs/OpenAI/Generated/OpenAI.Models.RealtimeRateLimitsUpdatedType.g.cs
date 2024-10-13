
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "rate_limits.updated".<br/>
    /// Example: rate_limits.updated
    /// </summary>
    public enum RealtimeRateLimitsUpdatedType
    {
        /// <summary>
        /// 
        /// </summary>
        RateLimitsUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeRateLimitsUpdatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeRateLimitsUpdatedType value)
        {
            return value switch
            {
                RealtimeRateLimitsUpdatedType.RateLimitsUpdated => "rate_limits.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeRateLimitsUpdatedType? ToEnum(string value)
        {
            return value switch
            {
                "rate_limits.updated" => RealtimeRateLimitsUpdatedType.RateLimitsUpdated,
                _ => null,
            };
        }
    }
}