
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.input_audio_buffer.append`.
    /// </summary>
    public enum RealtimeTranslationClientEventInputAudioBufferAppendType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionInputAudioBufferAppend,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationClientEventInputAudioBufferAppendTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationClientEventInputAudioBufferAppendType value)
        {
            return value switch
            {
                RealtimeTranslationClientEventInputAudioBufferAppendType.SessionInputAudioBufferAppend => "session.input_audio_buffer.append",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationClientEventInputAudioBufferAppendType? ToEnum(string value)
        {
            return value switch
            {
                "session.input_audio_buffer.append" => RealtimeTranslationClientEventInputAudioBufferAppendType.SessionInputAudioBufferAppend,
                _ => null,
            };
        }
    }
}