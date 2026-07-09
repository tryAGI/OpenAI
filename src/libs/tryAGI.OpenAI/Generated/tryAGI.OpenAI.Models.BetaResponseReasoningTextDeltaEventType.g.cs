
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_text.delta`.
    /// </summary>
    public enum BetaResponseReasoningTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseReasoningTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseReasoningTextDeltaEventType value)
        {
            return value switch
            {
                BetaResponseReasoningTextDeltaEventType.ResponseReasoningTextDelta => "response.reasoning_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseReasoningTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_text.delta" => BetaResponseReasoningTextDeltaEventType.ResponseReasoningTextDelta,
                _ => null,
            };
        }
    }
}