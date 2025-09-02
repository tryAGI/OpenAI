
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `response.output_audio.done`.
    /// </summary>
    public enum RealtimeServerEventResponseAudioDoneType
    {
        /// <summary>
        /// 
        /// </summary>
        ResponseOutputAudioDone,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventResponseAudioDoneTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventResponseAudioDoneType value)
        {
            return value switch
            {
                RealtimeServerEventResponseAudioDoneType.ResponseOutputAudioDone => "response.output_audio.done",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventResponseAudioDoneType? ToEnum(string value)
        {
            return value switch
            {
                "response.output_audio.done" => RealtimeServerEventResponseAudioDoneType.ResponseOutputAudioDone,
                _ => null,
            };
        }
    }
}