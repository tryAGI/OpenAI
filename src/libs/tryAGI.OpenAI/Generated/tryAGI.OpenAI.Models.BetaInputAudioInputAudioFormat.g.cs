
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of the audio data. Currently supported formats are `mp3` and<br/>
    /// `wav`.
    /// </summary>
    public enum BetaInputAudioInputAudioFormat
    {
        /// <summary>
        ///
        /// </summary>
        Mp3,
        /// <summary>
        ///
        /// </summary>
        Wav,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputAudioInputAudioFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputAudioInputAudioFormat value)
        {
            return value switch
            {
                BetaInputAudioInputAudioFormat.Mp3 => "mp3",
                BetaInputAudioInputAudioFormat.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputAudioInputAudioFormat? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => BetaInputAudioInputAudioFormat.Mp3,
                "wav" => BetaInputAudioInputAudioFormat.Wav,
                _ => null,
            };
        }
    }
}