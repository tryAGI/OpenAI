
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio encoding. Always `audio/pcm`.<br/>
    /// Default Value: audio/pcm
    /// </summary>
    public enum LiveSessionAudioFormatPCMParamType
    {
        /// <summary>
        ///
        /// </summary>
        AudioPcm,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionAudioFormatPCMParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionAudioFormatPCMParamType value)
        {
            return value switch
            {
                LiveSessionAudioFormatPCMParamType.AudioPcm => "audio/pcm",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionAudioFormatPCMParamType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcm" => LiveSessionAudioFormatPCMParamType.AudioPcm,
                _ => null,
            };
        }
    }
}