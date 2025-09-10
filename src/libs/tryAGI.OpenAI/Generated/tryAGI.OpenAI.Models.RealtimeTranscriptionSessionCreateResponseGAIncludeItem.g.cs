
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateResponseGAIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ItemInputAudioTranscriptionLogprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateResponseGAIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseGAIncludeItem value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseGAIncludeItem.ItemInputAudioTranscriptionLogprobs => "item.input_audio_transcription.logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseGAIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "item.input_audio_transcription.logprobs" => RealtimeTranscriptionSessionCreateResponseGAIncludeItem.ItemInputAudioTranscriptionLogprobs,
                _ => null,
            };
        }
    }
}