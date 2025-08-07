
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type identifier.
    /// </summary>
    public enum ResponseCustomToolCallInputDeltaEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCustomToolCallInputDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCustomToolCallInputDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCustomToolCallInputDeltaEventType value)
        {
            return value switch
            {
                ResponseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta => "response.custom_tool_call_input.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCustomToolCallInputDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.delta" => ResponseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta,
                _ => null,
            };
        }
    }
}