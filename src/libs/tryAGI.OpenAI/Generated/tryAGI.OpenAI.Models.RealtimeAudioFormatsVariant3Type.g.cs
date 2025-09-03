
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio format. Always `audio/pcma`.
    /// </summary>
    public enum RealtimeAudioFormatsVariant3Type
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsVariant3TypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsVariant3Type value)
        {
            return value switch
            {
                RealtimeAudioFormatsVariant3Type.AudioPcma => "audio/pcma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsVariant3Type? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcma" => RealtimeAudioFormatsVariant3Type.AudioPcma,
                _ => null,
            };
        }
    }
}