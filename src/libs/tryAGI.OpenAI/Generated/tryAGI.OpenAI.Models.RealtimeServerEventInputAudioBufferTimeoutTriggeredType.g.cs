
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.timeout_triggered`.
    /// </summary>
    public enum RealtimeServerEventInputAudioBufferTimeoutTriggeredType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferTimeoutTriggered,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventInputAudioBufferTimeoutTriggeredTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventInputAudioBufferTimeoutTriggeredType value)
        {
            return value switch
            {
                RealtimeServerEventInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered => "input_audio_buffer.timeout_triggered",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventInputAudioBufferTimeoutTriggeredType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.timeout_triggered" => RealtimeServerEventInputAudioBufferTimeoutTriggeredType.InputAudioBufferTimeoutTriggered,
                _ => null,
            };
        }
    }
}