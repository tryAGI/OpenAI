
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.interpreting`.
    /// </summary>
    public enum BetaResponseCodeInterpreterCallInterpretingEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallInterpreting,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeInterpreterCallInterpretingEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeInterpreterCallInterpretingEventType value)
        {
            return value switch
            {
                BetaResponseCodeInterpreterCallInterpretingEventType.ResponseCodeInterpreterCallInterpreting => "response.code_interpreter_call.interpreting",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeInterpreterCallInterpretingEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.interpreting" => BetaResponseCodeInterpreterCallInterpretingEventType.ResponseCodeInterpreterCallInterpreting,
                _ => null,
            };
        }
    }
}