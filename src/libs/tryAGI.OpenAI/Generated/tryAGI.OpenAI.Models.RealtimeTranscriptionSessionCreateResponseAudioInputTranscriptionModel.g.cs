
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The model to use for transcription. Can be `gpt-4o-transcribe`, `gpt-4o-mini-transcribe`, or `whisper-1`.
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Whisper1 => "whisper-1",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-transcribe" => RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Gpt4oTranscribe,
                "gpt-4o-mini-transcribe" => RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Gpt4oMiniTranscribe,
                "whisper-1" => RealtimeTranscriptionSessionCreateResponseAudioInputTranscriptionModel.Whisper1,
                _ => null,
            };
        }
    }
}