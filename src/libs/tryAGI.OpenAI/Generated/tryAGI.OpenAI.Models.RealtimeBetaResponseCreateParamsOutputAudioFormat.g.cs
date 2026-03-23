
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of output audio. Options are `pcm16`, `g711_ulaw`, or `g711_alaw`.
    /// </summary>
    public enum RealtimeBetaResponseCreateParamsOutputAudioFormat
    {
        /// <summary>
        /// 
        /// </summary>
        G711Alaw,
        /// <summary>
        /// 
        /// </summary>
        G711Ulaw,
        /// <summary>
        /// 
        /// </summary>
        Pcm16,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaResponseCreateParamsOutputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaResponseCreateParamsOutputAudioFormat value)
        {
            return value switch
            {
                RealtimeBetaResponseCreateParamsOutputAudioFormat.G711Alaw => "g711_alaw",
                RealtimeBetaResponseCreateParamsOutputAudioFormat.G711Ulaw => "g711_ulaw",
                RealtimeBetaResponseCreateParamsOutputAudioFormat.Pcm16 => "pcm16",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaResponseCreateParamsOutputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "g711_alaw" => RealtimeBetaResponseCreateParamsOutputAudioFormat.G711Alaw,
                "g711_ulaw" => RealtimeBetaResponseCreateParamsOutputAudioFormat.G711Ulaw,
                "pcm16" => RealtimeBetaResponseCreateParamsOutputAudioFormat.Pcm16,
                _ => null,
            };
        }
    }
}