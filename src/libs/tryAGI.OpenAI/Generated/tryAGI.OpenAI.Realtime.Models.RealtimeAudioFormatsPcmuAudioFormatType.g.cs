
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The audio format. Always `audio/pcmu`.
    /// </summary>
    public enum RealtimeAudioFormatsPcmuAudioFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioPcmu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsPcmuAudioFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsPcmuAudioFormatType value)
        {
            return value switch
            {
                RealtimeAudioFormatsPcmuAudioFormatType.AudioPcmu => "audio/pcmu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsPcmuAudioFormatType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcmu" => RealtimeAudioFormatsPcmuAudioFormatType.AudioPcmu,
                _ => null,
            };
        }
    }
}