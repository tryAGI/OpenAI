
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
    /// </summary>
    public enum RealtimeBetaResponseOutputAudioFormat
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
    public static class RealtimeBetaResponseOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeBetaResponseOutputAudioFormat.Pcm16 => "pcm16",
                RealtimeBetaResponseOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeBetaResponseOutputAudioFormat.G711Alaw => "g711_alaw",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "pcm16" => RealtimeBetaResponseOutputAudioFormat.Pcm16,
                "g711_ulaw" => RealtimeBetaResponseOutputAudioFormat.G711Ulaw,
                "g711_alaw" => RealtimeBetaResponseOutputAudioFormat.G711Alaw,
                _ => null,
            };
        }
    }
}