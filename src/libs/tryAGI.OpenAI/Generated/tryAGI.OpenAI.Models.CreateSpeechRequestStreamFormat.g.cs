
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The format to stream the audio in. Supported formats are `sse` and `audio`. `sse` is not supported for `tts-1` or `tts-1-hd`.<br/>
    /// Default Value: audio
    /// </summary>
    public enum CreateSpeechRequestStreamFormat
    {
        /// <summary>
        /// 
        /// </summary>
        Sse,
        /// <summary>
        /// 
        /// </summary>
        Audio,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateSpeechRequestStreamFormatExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateSpeechRequestStreamFormat value)
        {
            return value switch
            {
                CreateSpeechRequestStreamFormat.Sse => "sse",
                CreateSpeechRequestStreamFormat.Audio => "audio",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateSpeechRequestStreamFormat? ToEnum(string value)
        {
            return value switch
            {
                "sse" => CreateSpeechRequestStreamFormat.Sse,
                "audio" => CreateSpeechRequestStreamFormat.Audio,
                _ => null,
            };
        }
    }
}