
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_audio.delta`.
    /// </summary>
    public enum RealtimeServerEventResponseAudioDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseAudioDeltaType value)
        {
            return value switch
            {
                RealtimeServerEventResponseAudioDeltaType.ResponseOutputAudioDelta => "response.output_audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.delta" => RealtimeServerEventResponseAudioDeltaType.ResponseOutputAudioDelta,
                _ => null,
            };
        }
    }
}