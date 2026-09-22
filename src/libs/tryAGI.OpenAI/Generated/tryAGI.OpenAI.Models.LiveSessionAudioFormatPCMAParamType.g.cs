
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The audio encoding. Always `audio/pcma`.<br/>
    /// Default Value: audio/pcma
    /// </summary>
    public enum LiveSessionAudioFormatPCMAParamType
    {
        /// <summary>
        ///
        /// </summary>
        AudioPcma,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSessionAudioFormatPCMAParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSessionAudioFormatPCMAParamType value)
        {
            return value switch
            {
                LiveSessionAudioFormatPCMAParamType.AudioPcma => "audio/pcma",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSessionAudioFormatPCMAParamType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcma" => LiveSessionAudioFormatPCMAParamType.AudioPcma,
                _ => null,
            };
        }
    }
}