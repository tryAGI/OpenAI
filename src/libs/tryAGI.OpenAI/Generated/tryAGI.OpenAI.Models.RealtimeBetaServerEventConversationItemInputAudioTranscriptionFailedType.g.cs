
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be<br/>
    /// `conversation.item.input_audio_transcription.failed`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionFailed,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed => "conversation.item.input_audio_transcription.failed",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.failed" => RealtimeBetaServerEventConversationItemInputAudioTranscriptionFailedType.ConversationItemInputAudioTranscriptionFailed,
                _ => null,
            };
        }
    }
}