
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type identifier.
    /// </summary>
    public enum BetaResponseCustomToolCallInputDeltaEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCustomToolCallInputDeltaEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCustomToolCallInputDeltaEventType value)
        {
            return value switch
            {
                BetaResponseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta => "response.custom_tool_call_input.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCustomToolCallInputDeltaEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.delta" => BetaResponseCustomToolCallInputDeltaEventType.ResponseCustomToolCallInputDelta,
                _ => null,
            };
        }
    }
}