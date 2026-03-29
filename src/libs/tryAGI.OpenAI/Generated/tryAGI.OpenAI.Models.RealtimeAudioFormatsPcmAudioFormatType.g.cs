
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio format. Always `audio/pcm`.
    /// </summary>
    public enum RealtimeAudioFormatsPcmAudioFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsPcmAudioFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsPcmAudioFormatType value)
        {
            return value switch
            {
                RealtimeAudioFormatsPcmAudioFormatType.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsPcmAudioFormatType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcm" => RealtimeAudioFormatsPcmAudioFormatType.AudioPcm,
                _ => null,
            };
        }
    }
}