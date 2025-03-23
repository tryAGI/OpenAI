
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of input audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
    /// For `pcm16`, input audio must be 16-bit PCM at a 24kHz sample rate, <br/>
    /// single channel (mono), and little-endian byte order.<br/>
    /// Default Value: pcm16
    /// </summary>
    public enum RealtimeSessionCreateRequestInputAudioFormat
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
    public static class RealtimeSessionCreateRequestInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestInputAudioFormat value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestInputAudioFormat.Pcm16 => "pcm16",
                RealtimeSessionCreateRequestInputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeSessionCreateRequestInputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeSessionCreateRequestInputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeSessionCreateRequestInputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeSessionCreateRequestInputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}