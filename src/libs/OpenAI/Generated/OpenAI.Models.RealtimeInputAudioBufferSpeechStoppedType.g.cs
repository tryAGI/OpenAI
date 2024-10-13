
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "input_audio_buffer.speech_stopped".<br/>
    /// Example: input_audio_buffer.speech_stopped
    /// </summary>
    public enum RealtimeInputAudioBufferSpeechStoppedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeInputAudioBufferSpeechStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeInputAudioBufferSpeechStoppedType value)
        {
            return value switch
            {
                RealtimeInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeInputAudioBufferSpeechStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => RealtimeInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}