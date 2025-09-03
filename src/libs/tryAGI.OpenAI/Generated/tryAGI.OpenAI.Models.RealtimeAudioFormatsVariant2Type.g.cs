
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio format. Always `audio/pcmu`.
    /// </summary>
    public enum RealtimeAudioFormatsVariant2Type
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcmu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsVariant2TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsVariant2Type value)
        {
            return value switch
            {
                RealtimeAudioFormatsVariant2Type.AudioPcmu => "audio/pcmu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsVariant2Type? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcmu" => RealtimeAudioFormatsVariant2Type.AudioPcmu,
                _ => null,
            };
        }
    }
}