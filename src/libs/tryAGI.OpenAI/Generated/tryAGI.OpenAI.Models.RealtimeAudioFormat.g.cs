
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of input/output audio.
    /// </summary>
    public enum RealtimeAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
        /// <summary>
        /// 
        /// </summary>
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        G711Alaw,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeAudioFormat value)
        {
            return value switch
            {
                RealtimeAudioFormat.Pcm16 => "pcm16",
                RealtimeAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}