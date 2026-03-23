
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe20251215,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribeDiarize,
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
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
                AudioTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                AudioTranscriptionModel.Gpt4oMiniTranscribe20251215 => "gpt-4o-mini-transcribe-2025-12-15",
                AudioTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                AudioTranscriptionModel.Gpt4oTranscribeDiarize => "gpt-4o-transcribe-diarize",
                AudioTranscriptionModel.Whisper1 => "whisper-1",
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
                "gpt-4o-mini-transcribe" => AudioTranscriptionModel.Gpt4oMiniTranscribe,
                "gpt-4o-mini-transcribe-2025-12-15" => AudioTranscriptionModel.Gpt4oMiniTranscribe20251215,
                "gpt-4o-transcribe" => AudioTranscriptionModel.Gpt4oTranscribe,
                "gpt-4o-transcribe-diarize" => AudioTranscriptionModel.Gpt4oTranscribeDiarize,
                "whisper-1" => AudioTranscriptionModel.Whisper1,
                _ => null,
            };
        }
    }
}