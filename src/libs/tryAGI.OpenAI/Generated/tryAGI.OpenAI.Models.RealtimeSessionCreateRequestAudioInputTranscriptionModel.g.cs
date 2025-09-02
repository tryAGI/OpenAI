
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The model to use for transcription. Current options are<br/>
    /// `whisper-1`, `gpt-4o-transcribe-latest`, `gpt-4o-mini-transcribe`, `gpt-4o-transcribe`,<br/>
    /// and `gpt-4o-transcribe-diarize`.
    /// </summary>
    public enum RealtimeSessionCreateRequestAudioInputTranscriptionModel
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
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribeDiarize,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestAudioInputTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestAudioInputTranscriptionModel value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestAudioInputTranscriptionModel.Whisper1 => "whisper-1",
                RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribeLatest => "gpt-4o-transcribe-latest",
                RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribeDiarize => "gpt-4o-transcribe-diarize",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestAudioInputTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-1" => RealtimeSessionCreateRequestAudioInputTranscriptionModel.Whisper1,
                "gpt-4o-transcribe-latest" => RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribeLatest,
                "gpt-4o-mini-transcribe" => RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oMiniTranscribe,
                "gpt-4o-transcribe" => RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribe,
                "gpt-4o-transcribe-diarize" => RealtimeSessionCreateRequestAudioInputTranscriptionModel.Gpt4oTranscribeDiarize,
                _ => null,
            };
        }
    }
}