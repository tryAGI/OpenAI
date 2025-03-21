
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.code.done`.
    /// </summary>
    public enum ResponseCodeInterpreterCallCodeDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ResponseCodeInterpreterCallCodeDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ResponseCodeInterpreterCallCodeDoneEventType value)
        {
            return value switch
            {
                ResponseCodeInterpreterCallCodeDoneEventType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call.code.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ResponseCodeInterpreterCallCodeDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.code.done" => ResponseCodeInterpreterCallCodeDoneEventType.ResponseCodeInterpreterCallCodeDone,
                _ => null,
            };
        }
    }
}