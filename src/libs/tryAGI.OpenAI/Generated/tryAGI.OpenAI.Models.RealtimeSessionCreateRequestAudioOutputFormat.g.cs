
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.<br/>
    /// For `pcm16`, output audio is sampled at a rate of 24kHz.<br/>
    /// Default Value: pcm16
    /// </summary>
    public enum RealtimeSessionCreateRequestAudioOutputFormat
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
    public static class RealtimeSessionCreateRequestAudioOutputFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestAudioOutputFormat value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestAudioOutputFormat.Pcm16 => "pcm16",
                RealtimeSessionCreateRequestAudioOutputFormat.G711Ulaw => "g711_ulaw",
                RealtimeSessionCreateRequestAudioOutputFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestAudioOutputFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeSessionCreateRequestAudioOutputFormat.Pcm16,
                "g711_ulaw" => RealtimeSessionCreateRequestAudioOutputFormat.G711Ulaw,
                "g711_alaw" => RealtimeSessionCreateRequestAudioOutputFormat.G711Alaw,
                _ => null,
            };
        }
    }
}