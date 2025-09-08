
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.speech_stopped`.
    /// </summary>
    public enum RealtimeBetaServerEventInputAudioBufferSpeechStoppedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStopped,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventInputAudioBufferSpeechStoppedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventInputAudioBufferSpeechStoppedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped => "input_audio_buffer.speech_stopped",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventInputAudioBufferSpeechStoppedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_stopped" => RealtimeBetaServerEventInputAudioBufferSpeechStoppedType.InputAudioBufferSpeechStopped,
                _ => null,
            };
        }
    }
}