
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format of the audio data. Currently supported formats are `mp3` and<br/>
    /// `wav`.
    /// </summary>
    public enum InputAudioInputAudio1Format
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
    public static class InputAudioInputAudio1FormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this InputAudioInputAudio1Format value)
        {
            return value switch
            {
                InputAudioInputAudio1Format.Mp3 => "mp3",
                InputAudioInputAudio1Format.Wav => "wav",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static InputAudioInputAudio1Format? ToEnum(string value)
        {
            return value switch
            {
                "mp3" => InputAudioInputAudio1Format.Mp3,
                "wav" => InputAudioInputAudio1Format.Wav,
                _ => null,
            };
        }
    }
}