
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.input_audio_transcription.failed".<br/>
    /// Example: conversation.item.input_audio_transcription.failed
    /// </summary>
    public enum RealtimeConversationItemInputAudioTranscriptionFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemInputAudioTranscriptionFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemInputAudioTranscriptionFailedType value)
        {
            return value switch
            {
                RealtimeConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemInputAudioTranscriptionFailedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.failed" => RealtimeConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed,
                _ => null,
            };
        }
    }
}