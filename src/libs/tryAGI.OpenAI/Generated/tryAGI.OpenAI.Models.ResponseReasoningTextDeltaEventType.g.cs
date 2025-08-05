
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_text.delta`.
    /// </summary>
    public enum ResponseReasoningTextDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningTextDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningTextDeltaEventType value)
        {
            return value switch
            {
                ResponseReasoningTextDeltaEventType.ResponseReasoningTextDelta => "response.reasoning_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningTextDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_text.delta" => ResponseReasoningTextDeltaEventType.ResponseReasoningTextDelta,
                _ => null,
            };
        }
    }
}