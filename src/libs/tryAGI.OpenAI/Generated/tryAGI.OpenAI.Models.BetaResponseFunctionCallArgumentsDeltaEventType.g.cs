
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `response.function_call_arguments.delta`.
    /// </summary>
    public enum BetaResponseFunctionCallArgumentsDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseFunctionCallArgumentsDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseFunctionCallArgumentsDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseFunctionCallArgumentsDeltaEventType value)
        {
            return value switch
            {
                BetaResponseFunctionCallArgumentsDeltaEventType.ResponseFunctionCallArgumentsDelta => "response.function_call_arguments.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseFunctionCallArgumentsDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.function_call_arguments.delta" => BetaResponseFunctionCallArgumentsDeltaEventType.ResponseFunctionCallArgumentsDelta,
                _ => null,
            };
        }
    }
}