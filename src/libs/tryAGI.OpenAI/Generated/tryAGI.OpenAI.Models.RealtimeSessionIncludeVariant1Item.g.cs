
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionIncludeVariant1Item
    {
        /// <summary>
        /// 
        /// </summary>
        ItemInputAudioTranscriptionLogprobs,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionIncludeVariant1ItemExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionIncludeVariant1Item value)
        {
            return value switch
            {
                RealtimeSessionIncludeVariant1Item.ItemInputAudioTranscriptionLogprobs => "item.input_audio_transcription.logprobs",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionIncludeVariant1Item? ToEnum(string value)
        {
            return value switch
            {
                "item.input_audio_transcription.logprobs" => RealtimeSessionIncludeVariant1Item.ItemInputAudioTranscriptionLogprobs,
                _ => null,
            };
        }
    }
}