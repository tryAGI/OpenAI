
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Audio encoding for `delta`.
    /// </summary>
    public enum RealtimeTranslationServerEventSessionOutputAudioDeltaFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranslationServerEventSessionOutputAudioDeltaFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranslationServerEventSessionOutputAudioDeltaFormat value)
        {
            return value switch
            {
                RealtimeTranslationServerEventSessionOutputAudioDeltaFormat.Pcm16 => "pcm16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranslationServerEventSessionOutputAudioDeltaFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeTranslationServerEventSessionOutputAudioDeltaFormat.Pcm16,
                _ => null,
            };
        }
    }
}