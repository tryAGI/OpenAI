
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The model to use for transcription. Current options are `whisper-1`, `gpt-4o-transcribe-latest`, `gpt-4o-mini-transcribe`, and `gpt-4o-transcribe`.
    /// </summary>
    public enum AudioTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribeLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionModel value)
        {
            return value switch
            {
                AudioTranscriptionModel.Whisper1 => "whisper-1",
                AudioTranscriptionModel.Gpt4oTranscribeLatest => "gpt-4o-transcribe-latest",
                AudioTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                AudioTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-1" => AudioTranscriptionModel.Whisper1,
                "gpt-4o-transcribe-latest" => AudioTranscriptionModel.Gpt4oTranscribeLatest,
                "gpt-4o-mini-transcribe" => AudioTranscriptionModel.Gpt4oMiniTranscribe,
                "gpt-4o-transcribe" => AudioTranscriptionModel.Gpt4oTranscribe,
                _ => null,
            };
        }
    }
}