
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `input_audio_buffer.speech_started`.
    /// </summary>
    public enum RealtimeBetaServerEventInputAudioBufferSpeechStartedType
    {
        /// <summary>
        /// 
        /// </summary>
        InputAudioBufferSpeechStarted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventInputAudioBufferSpeechStartedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventInputAudioBufferSpeechStartedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted => "input_audio_buffer.speech_started",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventInputAudioBufferSpeechStartedType? ToEnum(string value)
        {
            return value switch
            {
                "input_audio_buffer.speech_started" => RealtimeBetaServerEventInputAudioBufferSpeechStartedType.InputAudioBufferSpeechStarted,
                _ => null,
            };
        }
    }
}