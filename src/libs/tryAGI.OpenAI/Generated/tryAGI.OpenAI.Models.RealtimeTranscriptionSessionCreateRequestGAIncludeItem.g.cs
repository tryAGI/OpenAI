
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestGAIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ItemInputAudioTranscriptionLogprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestGAIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestGAIncludeItem value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestGAIncludeItem.ItemInputAudioTranscriptionLogprobs => "item.input_audio_transcription.logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestGAIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "item.input_audio_transcription.logprobs" => RealtimeTranscriptionSessionCreateRequestGAIncludeItem.ItemInputAudioTranscriptionLogprobs,
                _ => null,
            };
        }
    }
}