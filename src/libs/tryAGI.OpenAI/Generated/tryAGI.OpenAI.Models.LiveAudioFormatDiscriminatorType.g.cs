
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveAudioFormatDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        AudioPcm,
        /// <summary>
        ///
        /// </summary>
        AudioPcma,
        /// <summary>
        ///
        /// </summary>
        AudioPcmu,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveAudioFormatDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveAudioFormatDiscriminatorType value)
        {
            return value switch
            {
                LiveAudioFormatDiscriminatorType.AudioPcm => "audio/pcm",
                LiveAudioFormatDiscriminatorType.AudioPcma => "audio/pcma",
                LiveAudioFormatDiscriminatorType.AudioPcmu => "audio/pcmu",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveAudioFormatDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "audio/pcm" => LiveAudioFormatDiscriminatorType.AudioPcm,
                "audio/pcma" => LiveAudioFormatDiscriminatorType.AudioPcma,
                "audio/pcmu" => LiveAudioFormatDiscriminatorType.AudioPcmu,
                _ => null,
            };
        }
    }
}