
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.input_audio_transcription.segment`.
    /// </summary>
    public enum RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemInputAudioTranscriptionSegment,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationItemInputAudioTranscriptionSegmentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType value)
        {
            return value switch
            {
                RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType.ConversationItemInputAudioTranscriptionSegment => "conversation.item.input_audio_transcription.segment",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.input_audio_transcription.segment" => RealtimeServerEventConversationItemInputAudioTranscriptionSegmentType.ConversationItemInputAudioTranscriptionSegment,
                _ => null,
            };
        }
    }
}