
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call_code.delta`.
    /// </summary>
    public enum BetaResponseCodeInterpreterCallCodeDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCodeDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeInterpreterCallCodeDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeInterpreterCallCodeDeltaEventType value)
        {
            return value switch
            {
                BetaResponseCodeInterpreterCallCodeDeltaEventType.ResponseCodeInterpreterCallCodeDelta => "response.code_interpreter_call_code.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeInterpreterCallCodeDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call_code.delta" => BetaResponseCodeInterpreterCallCodeDeltaEventType.ResponseCodeInterpreterCallCodeDelta,
                _ => null,
            };
        }
    }
}