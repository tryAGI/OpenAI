
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type identifier.
    /// </summary>
    public enum BetaResponseCustomToolCallInputDoneEventType
    {
        /// <summary>
        ///
        /// </summary>
        ResponseCustomToolCallInputDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaResponseCustomToolCallInputDoneEventTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaResponseCustomToolCallInputDoneEventType value)
        {
            return value switch
            {
                BetaResponseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone => "response.custom_tool_call_input.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaResponseCustomToolCallInputDoneEventType? ToEnum(string value)
        {
            return value switch
            {
                "response.custom_tool_call_input.done" => BetaResponseCustomToolCallInputDoneEventType.ResponseCustomToolCallInputDone,
                _ => null,
            };
        }
    }
}