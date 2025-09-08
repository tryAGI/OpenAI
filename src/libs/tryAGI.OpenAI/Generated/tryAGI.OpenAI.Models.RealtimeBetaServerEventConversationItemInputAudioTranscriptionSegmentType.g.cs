
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.input_audio_transcription.segment`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType.ConversationItemInputAudioTranscriptionSegment => "conversation.item.input_audio_transcription.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.segment" => RealtimeBetaServerEventConversationItemInputAudioTranscriptionSegmentType.ConversationItemInputAudioTranscriptionSegment,
                _ => null,
            };
        }
    }
}