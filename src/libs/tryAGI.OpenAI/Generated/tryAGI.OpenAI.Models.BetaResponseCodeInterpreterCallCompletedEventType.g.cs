
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.completed`.
    /// </summary>
    public enum BetaResponseCodeInterpreterCallCompletedEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCodeInterpreterCallCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeInterpreterCallCompletedEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeInterpreterCallCompletedEventType value)
        {
            return value switch
            {
                BetaResponseCodeInterpreterCallCompletedEventType.ResponseCodeInterpreterCallCompleted => "response.code_interpreter_call.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeInterpreterCallCompletedEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.completed" => BetaResponseCodeInterpreterCallCompletedEventType.ResponseCodeInterpreterCallCompleted,
                _ => null,
            };
        }
    }
}