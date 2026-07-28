
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum AudioTranscriptionResponseModel
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
        GptLiveTranscribe,
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeWhisper,
        /// <summary>
        /// 
        /// </summary>
        GptTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class AudioTranscriptionResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this AudioTranscriptionResponseModel value)
        {
            return value switch
            {
                AudioTranscriptionResponseModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                AudioTranscriptionResponseModel.Gpt4oMiniTranscribe20251215 => "gpt-4o-mini-transcribe-2025-12-15",
                AudioTranscriptionResponseModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                AudioTranscriptionResponseModel.Gpt4oTranscribeDiarize => "gpt-4o-transcribe-diarize",
                AudioTranscriptionResponseModel.GptLiveTranscribe => "gpt-live-transcribe",
                AudioTranscriptionResponseModel.GptRealtimeWhisper => "gpt-realtime-whisper",
                AudioTranscriptionResponseModel.GptTranscribe => "gpt-transcribe",
                AudioTranscriptionResponseModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static AudioTranscriptionResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-transcribe" => AudioTranscriptionResponseModel.Gpt4oMiniTranscribe,
                "gpt-4o-mini-transcribe-2025-12-15" => AudioTranscriptionResponseModel.Gpt4oMiniTranscribe20251215,
                "gpt-4o-transcribe" => AudioTranscriptionResponseModel.Gpt4oTranscribe,
                "gpt-4o-transcribe-diarize" => AudioTranscriptionResponseModel.Gpt4oTranscribeDiarize,
                "gpt-live-transcribe" => AudioTranscriptionResponseModel.GptLiveTranscribe,
                "gpt-realtime-whisper" => AudioTranscriptionResponseModel.GptRealtimeWhisper,
                "gpt-transcribe" => AudioTranscriptionResponseModel.GptTranscribe,
                "whisper-1" => AudioTranscriptionResponseModel.Whisper1,
                _ => null,
            };
        }
    }
}