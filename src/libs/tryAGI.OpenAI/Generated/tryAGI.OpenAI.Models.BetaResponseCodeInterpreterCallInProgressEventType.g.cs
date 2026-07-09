
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.code_interpreter_call.in_progress`.
    /// </summary>
    public enum BetaResponseCodeInterpreterCallInProgressEventType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseCodeInterpreterCallInProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCodeInterpreterCallInProgressEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCodeInterpreterCallInProgressEventType value)
        {
            return value switch
            {
                BetaResponseCodeInterpreterCallInProgressEventType.ResponseCodeInterpreterCallInProgress => "response.code_interpreter_call.in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCodeInterpreterCallInProgressEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.code_interpreter_call.in_progress" => BetaResponseCodeInterpreterCallInProgressEventType.ResponseCodeInterpreterCallInProgress,
                _ => null,
            };
        }
    }
}