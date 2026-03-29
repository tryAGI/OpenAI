
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio format. Always `audio/pcma`.
    /// </summary>
    public enum RealtimeAudioFormatsPcmaAudioFormatType
    {
        /// <summary>
        /// 
        /// </summary>
        AudioDividepcma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatsPcmaAudioFormatTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormatsPcmaAudioFormatType value)
        {
            return value switch
            {
                RealtimeAudioFormatsPcmaAudioFormatType.AudioDividepcma => "audio/pcma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormatsPcmaAudioFormatType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcma" => RealtimeAudioFormatsPcmaAudioFormatType.AudioDividepcma,
                _ => null,
            };
        }
    }
}