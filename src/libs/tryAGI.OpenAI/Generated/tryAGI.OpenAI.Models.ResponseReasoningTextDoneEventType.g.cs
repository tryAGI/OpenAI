
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.reasoning_text.done`.
    /// </summary>
    public enum ResponseReasoningTextDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseReasoningTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseReasoningTextDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseReasoningTextDoneEventType value)
        {
            return value switch
            {
                ResponseReasoningTextDoneEventType.ResponseReasoningTextDone => "response.reasoning_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseReasoningTextDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.reasoning_text.done" => ResponseReasoningTextDoneEventType.ResponseReasoningTextDone,
                _ => null,
            };
        }
    }
}