
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `session.output_audio.delta`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionOutputAudioDeltaType
    {
        /// <summary>
        /// 
        /// </summary>
        SessionOutputAudioDelta,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionOutputAudioDeltaTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionOutputAudioDeltaType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionOutputAudioDeltaType.SessionOutputAudioDelta => "session.output_audio.delta",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionOutputAudioDeltaType? ToEnum(string value)
        {
            return value switch
            {
                "session.output_audio.delta" => RealtimeTranslationServerEventSessionOutputAudioDeltaType.SessionOutputAudioDelta,
                _ => null,
            };
        }
    }
}