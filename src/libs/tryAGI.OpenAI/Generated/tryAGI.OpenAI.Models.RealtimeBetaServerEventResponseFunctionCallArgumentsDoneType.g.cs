
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.function_call_arguments.done`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseFunctionCallArgumentsDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => RealtimeBetaServerEventResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}