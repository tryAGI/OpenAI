
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "response.function_call_arguments.delta".<br/>
    /// Example: response.function_call_arguments.delta
    /// </summary>
    public enum RealtimeResponseFunctionCallArgumentsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeResponseFunctionCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeResponseFunctionCallArgumentsDeltaType value)
        {
            return value switch
            {
                RealtimeResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeResponseFunctionCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => RealtimeResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}