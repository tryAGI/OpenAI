
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeTranscriptionSessionCreateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        Whisper1,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oTranscribe,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniTranscribe,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeTranscriptionSessionCreateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeTranscriptionSessionCreateRequestModel value)
        {
            return value switch
            {
                RealtimeTranscriptionSessionCreateRequestModel.Whisper1 => "whisper-1",
                RealtimeTranscriptionSessionCreateRequestModel.Gpt4oTranscribe => "gpt-4o-transcribe",
                RealtimeTranscriptionSessionCreateRequestModel.Gpt4oMiniTranscribe => "gpt-4o-mini-transcribe",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeTranscriptionSessionCreateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "whisper-1" => RealtimeTranscriptionSessionCreateRequestModel.Whisper1,
                "gpt-4o-transcribe" => RealtimeTranscriptionSessionCreateRequestModel.Gpt4oTranscribe,
                "gpt-4o-mini-transcribe" => RealtimeTranscriptionSessionCreateRequestModel.Gpt4oMiniTranscribe,
                _ => null,
            };
        }
    }
}