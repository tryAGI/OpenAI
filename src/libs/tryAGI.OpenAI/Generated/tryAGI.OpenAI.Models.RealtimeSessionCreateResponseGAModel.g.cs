
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseGAModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniRealtimePreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniRealtimePreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oRealtimePreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oRealtimePreview20241001,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oRealtimePreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oRealtimePreview20250603,
        /// <summary>
        /// 
        /// </summary>
        GptAudio15,
        /// <summary>
        /// 
        /// </summary>
        GptAudioMini,
        /// <summary>
        /// 
        /// </summary>
        GptAudioMini20251006,
        /// <summary>
        /// 
        /// </summary>
        GptAudioMini20251215,
        /// <summary>
        /// 
        /// </summary>
        GptRealtime,
        /// <summary>
        /// 
        /// </summary>
        GptRealtime15,
        /// <summary>
        /// 
        /// </summary>
        GptRealtime20250828,
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeMini,
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeMini20251006,
        /// <summary>
        /// 
        /// </summary>
        GptRealtimeMini20251215,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateResponseGAModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseGAModel value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseGAModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionCreateResponseGAModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20250603 => "gpt-4o-realtime-preview-2025-06-03",
                RealtimeSessionCreateResponseGAModel.GptAudio15 => "gpt-audio-1.5",
                RealtimeSessionCreateResponseGAModel.GptAudioMini => "gpt-audio-mini",
                RealtimeSessionCreateResponseGAModel.GptAudioMini20251006 => "gpt-audio-mini-2025-10-06",
                RealtimeSessionCreateResponseGAModel.GptAudioMini20251215 => "gpt-audio-mini-2025-12-15",
                RealtimeSessionCreateResponseGAModel.GptRealtime => "gpt-realtime",
                RealtimeSessionCreateResponseGAModel.GptRealtime15 => "gpt-realtime-1.5",
                RealtimeSessionCreateResponseGAModel.GptRealtime20250828 => "gpt-realtime-2025-08-28",
                RealtimeSessionCreateResponseGAModel.GptRealtimeMini => "gpt-realtime-mini",
                RealtimeSessionCreateResponseGAModel.GptRealtimeMini20251006 => "gpt-realtime-mini-2025-10-06",
                RealtimeSessionCreateResponseGAModel.GptRealtimeMini20251215 => "gpt-realtime-mini-2025-12-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseGAModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-realtime-preview" => RealtimeSessionCreateResponseGAModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionCreateResponseGAModel.Gpt4oMiniRealtimePreview20241217,
                "gpt-4o-realtime-preview" => RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-realtime-preview-2025-06-03" => RealtimeSessionCreateResponseGAModel.Gpt4oRealtimePreview20250603,
                "gpt-audio-1.5" => RealtimeSessionCreateResponseGAModel.GptAudio15,
                "gpt-audio-mini" => RealtimeSessionCreateResponseGAModel.GptAudioMini,
                "gpt-audio-mini-2025-10-06" => RealtimeSessionCreateResponseGAModel.GptAudioMini20251006,
                "gpt-audio-mini-2025-12-15" => RealtimeSessionCreateResponseGAModel.GptAudioMini20251215,
                "gpt-realtime" => RealtimeSessionCreateResponseGAModel.GptRealtime,
                "gpt-realtime-1.5" => RealtimeSessionCreateResponseGAModel.GptRealtime15,
                "gpt-realtime-2025-08-28" => RealtimeSessionCreateResponseGAModel.GptRealtime20250828,
                "gpt-realtime-mini" => RealtimeSessionCreateResponseGAModel.GptRealtimeMini,
                "gpt-realtime-mini-2025-10-06" => RealtimeSessionCreateResponseGAModel.GptRealtimeMini20251006,
                "gpt-realtime-mini-2025-12-15" => RealtimeSessionCreateResponseGAModel.GptRealtimeMini20251215,
                _ => null,
            };
        }
    }
}