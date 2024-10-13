
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.item.input_audio_transcription.completed".<br/>
    /// Example: conversation.item.input_audio_transcription.completed
    /// </summary>
    public enum RealtimeConversationItemInputAudioTranscriptionCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemInputAudioTranscriptionCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemInputAudioTranscriptionCompletedType value)
        {
            return value switch
            {
                RealtimeConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemInputAudioTranscriptionCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.completed" => RealtimeConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}