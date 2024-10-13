
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.function_call_arguments.done".<br/>
    /// Example: response.function_call_arguments.done
    /// </summary>
    public enum RealtimeResponseFunctionCallArgumentsDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseFunctionCallArgumentsDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseFunctionCallArgumentsDoneType value)
        {
            return value switch
            {
                RealtimeResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone => "response.function_call_arguments.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseFunctionCallArgumentsDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.done" => RealtimeResponseFunctionCallArgumentsDoneType.ResponseFunctionCallArgumentsDone,
                _ => null,
            };
        }
    }
}