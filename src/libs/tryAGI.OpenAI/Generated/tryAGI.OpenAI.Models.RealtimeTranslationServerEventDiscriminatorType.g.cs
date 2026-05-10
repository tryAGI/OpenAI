
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranslationServerEventDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        Error,
        /// <summary>
        /// 
        /// </summary>
        SessionClosed,
        /// <summary>
        /// 
        /// </summary>
        SessionCreated,
        /// <summary>
        /// 
        /// </summary>
        SessionInputTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        SessionOutputAudioDelta,
        /// <summary>
        /// 
        /// </summary>
        SessionOutputTranscriptDelta,
        /// <summary>
        /// 
        /// </summary>
        SessionUpdated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventDiscriminatorType value)
        {
            return value switch
            {
                RealtimeTranslationServerEventDiscriminatorType.Error => "error",
                RealtimeTranslationServerEventDiscriminatorType.SessionClosed => "session.closed",
                RealtimeTranslationServerEventDiscriminatorType.SessionCreated => "session.created",
                RealtimeTranslationServerEventDiscriminatorType.SessionInputTranscriptDelta => "session.input_transcript.delta",
                RealtimeTranslationServerEventDiscriminatorType.SessionOutputAudioDelta => "session.output_audio.delta",
                RealtimeTranslationServerEventDiscriminatorType.SessionOutputTranscriptDelta => "session.output_transcript.delta",
                RealtimeTranslationServerEventDiscriminatorType.SessionUpdated => "session.updated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "error" => RealtimeTranslationServerEventDiscriminatorType.Error,
                "session.closed" => RealtimeTranslationServerEventDiscriminatorType.SessionClosed,
                "session.created" => RealtimeTranslationServerEventDiscriminatorType.SessionCreated,
                "session.input_transcript.delta" => RealtimeTranslationServerEventDiscriminatorType.SessionInputTranscriptDelta,
                "session.output_audio.delta" => RealtimeTranslationServerEventDiscriminatorType.SessionOutputAudioDelta,
                "session.output_transcript.delta" => RealtimeTranslationServerEventDiscriminatorType.SessionOutputTranscriptDelta,
                "session.updated" => RealtimeTranslationServerEventDiscriminatorType.SessionUpdated,
                _ => null,
            };
        }
    }
}