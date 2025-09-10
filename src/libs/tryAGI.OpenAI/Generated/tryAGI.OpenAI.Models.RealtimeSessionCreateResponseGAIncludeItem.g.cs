
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseGAIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ItemInputAudioTranscriptionLogprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGAIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAIncludeItem value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAIncludeItem.ItemInputAudioTranscriptionLogprobs => "item.input_audio_transcription.logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "item.input_audio_transcription.logprobs" => RealtimeSessionCreateResponseGAIncludeItem.ItemInputAudioTranscriptionLogprobs,
                _ => null,
            };
        }
    }
}