
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call_code.done`.
    /// </summary>
    public enum BetaResponseCodeInterpreterCallCodeDoneEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallCodeDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeInterpreterCallCodeDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeInterpreterCallCodeDoneEventType value)
        {
            return value switch
            {
                BetaResponseCodeInterpreterCallCodeDoneEventType.ResponseCodeInterpreterCallCodeDone => "response.code_interpreter_call_code.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeInterpreterCallCodeDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call_code.done" => BetaResponseCodeInterpreterCallCodeDoneEventType.ResponseCodeInterpreterCallCodeDone,
                _ => null,
            };
        }
    }
}