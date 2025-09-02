
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_text.delta`.
    /// </summary>
    public enum RealtimeServerEventResponseTextDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputTextDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseTextDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseTextDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseTextDeltaType.ResponseOutputTextDelta => "response.output_text.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseTextDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_text.delta" => RealtimeServerEventResponseTextDeltaType.ResponseOutputTextDelta,
                _ => null,
            };
        }
    }
}