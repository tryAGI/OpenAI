
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestGAIncludeItem
    {
        /// <summary>
        /// 
        /// </summary>
        ItemInputAudioTranscriptionLogprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestGAIncludeItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGAIncludeItem value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGAIncludeItem.ItemInputAudioTranscriptionLogprobs => "item.input_audio_transcription.logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGAIncludeItem? ToEnum(string value)
        {
            return value switch
            {
                "item.input_audio_transcription.logprobs" => RealtimeSessionCreateRequestGAIncludeItem.ItemInputAudioTranscriptionLogprobs,
                _ => null,
            };
        }
    }
}