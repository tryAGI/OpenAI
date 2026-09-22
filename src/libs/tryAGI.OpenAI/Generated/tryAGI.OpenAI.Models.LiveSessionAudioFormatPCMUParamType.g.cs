
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio encoding. Always `audio/pcmu`.<br/>
    /// Default Value: audio/pcmu
    /// </summary>
    public enum LiveSessionAudioFormatPCMUParamType
    {
        /// <summary>
        ///
        /// </summary>
        AudioPcmu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionAudioFormatPCMUParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionAudioFormatPCMUParamType value)
        {
            return value switch
            {
                LiveSessionAudioFormatPCMUParamType.AudioPcmu => "audio/pcmu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionAudioFormatPCMUParamType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcmu" => LiveSessionAudioFormatPCMUParamType.AudioPcmu,
                _ => null,
            };
        }
    }
}