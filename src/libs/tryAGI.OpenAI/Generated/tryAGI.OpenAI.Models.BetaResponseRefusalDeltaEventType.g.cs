
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.refusal.delta`.
    /// </summary>
    public enum BetaResponseRefusalDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseRefusalDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseRefusalDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseRefusalDeltaEventType value)
        {
            return value switch
            {
                BetaResponseRefusalDeltaEventType.ResponseRefusalDelta => "response.refusal.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseRefusalDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.refusal.delta" => BetaResponseRefusalDeltaEventType.ResponseRefusalDelta,
                _ => null,
            };
        }
    }
}