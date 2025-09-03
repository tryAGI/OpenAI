
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio format. Always `audio/pcm`.
    /// </summary>
    public enum RealtimeAudioFormatsVariant1Type
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsVariant1TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsVariant1Type value)
        {
            return value switch
            {
                RealtimeAudioFormatsVariant1Type.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsVariant1Type? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcm" => RealtimeAudioFormatsVariant1Type.AudioPcm,
                _ => null,
            };
        }
    }
}