
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be<br/>
    /// `conversation.item.input_audio_transcription.completed`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionCompleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted => "conversation.item.input_audio_transcription.completed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.completed" => RealtimeBetaServerEventConversationItemInputAudioTranscriptionCompletedType.ConversationItemInputAudioTranscriptionCompleted,
                _ => null,
            };
        }
    }
}