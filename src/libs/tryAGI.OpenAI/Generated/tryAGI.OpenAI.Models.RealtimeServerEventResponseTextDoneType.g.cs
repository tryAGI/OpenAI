
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_text.done`.
    /// </summary>
    public enum RealtimeServerEventResponseTextDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseTextDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseTextDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseTextDoneType.ResponseOutputTextDone => "response.output_text.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseTextDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.done" => RealtimeServerEventResponseTextDoneType.ResponseOutputTextDone,
                _ => null,
            };
        }
    }
}