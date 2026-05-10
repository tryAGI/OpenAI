
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranslationClientEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionClose,
        /// <summary>
        /// 
        /// </summary>
        SessionInputAudioBufferAppend,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationClientEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationClientEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeTranslationClientEventDiscriminatorType.SessionClose => "session.close",
                RealtimeTranslationClientEventDiscriminatorType.SessionInputAudioBufferAppend => "session.input_audio_buffer.append",
                RealtimeTranslationClientEventDiscriminatorType.SessionUpdate => "session.update",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationClientEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "session.close" => RealtimeTranslationClientEventDiscriminatorType.SessionClose,
                "session.input_audio_buffer.append" => RealtimeTranslationClientEventDiscriminatorType.SessionInputAudioBufferAppend,
                "session.update" => RealtimeTranslationClientEventDiscriminatorType.SessionUpdate,
                _ => null,
            };
        }
    }
}