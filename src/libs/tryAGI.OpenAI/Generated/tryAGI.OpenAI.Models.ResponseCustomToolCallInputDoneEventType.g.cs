
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type identifier.
    /// </summary>
    public enum ResponseCustomToolCallInputDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCustomToolCallInputDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCustomToolCallInputDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCustomToolCallInputDoneEventType value)
        {
            return value switch
            {
                ResponseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone => "response.custom_tool_call_input.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCustomToolCallInputDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.done" => ResponseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone,
                _ => null,
            };
        }
    }
}