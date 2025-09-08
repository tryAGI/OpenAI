
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.function_call_arguments.delta`.
    /// </summary>
    public enum RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType value)
        {
            return value switch
            {
                RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => RealtimeBetaServerEventResponseFunctionCallArgumentsDeltaType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}