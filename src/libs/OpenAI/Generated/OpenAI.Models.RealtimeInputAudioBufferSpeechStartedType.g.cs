
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.speech_started".<br/>
    /// Example: input_audio_buffer.speech_started
    /// </summary>
    public enum RealtimeInputAudioBufferSpeechStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferSpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferSpeechStartedType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferSpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => RealtimeInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}