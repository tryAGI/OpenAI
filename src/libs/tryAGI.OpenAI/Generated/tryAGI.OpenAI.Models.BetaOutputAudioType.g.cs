
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the output audio. Always `output_audio`.
    /// </summary>
    public enum BetaOutputAudioType
    {
        /// <summary>
        ///
        /// </summary>
        OutputAudio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaOutputAudioTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaOutputAudioType value)
        {
            return value switch
            {
                BetaOutputAudioType.OutputAudio => "output_audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaOutputAudioType? ToEnum(string value)
        {
            return value switch
            {
                "output_audio" => BetaOutputAudioType.OutputAudio,
                _ => null,
            };
        }
    }
}