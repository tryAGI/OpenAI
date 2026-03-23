
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestGAModel
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
    public static class RealtimeSessionCreateRequestGAModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestGAModel value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestGAModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionCreateRequestGAModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20250603 => "gpt-4o-realtime-preview-2025-06-03",
                RealtimeSessionCreateRequestGAModel.GptAudio15 => "gpt-audio-1.5",
                RealtimeSessionCreateRequestGAModel.GptAudioMini => "gpt-audio-mini",
                RealtimeSessionCreateRequestGAModel.GptAudioMini20251006 => "gpt-audio-mini-2025-10-06",
                RealtimeSessionCreateRequestGAModel.GptAudioMini20251215 => "gpt-audio-mini-2025-12-15",
                RealtimeSessionCreateRequestGAModel.GptRealtime => "gpt-realtime",
                RealtimeSessionCreateRequestGAModel.GptRealtime15 => "gpt-realtime-1.5",
                RealtimeSessionCreateRequestGAModel.GptRealtime20250828 => "gpt-realtime-2025-08-28",
                RealtimeSessionCreateRequestGAModel.GptRealtimeMini => "gpt-realtime-mini",
                RealtimeSessionCreateRequestGAModel.GptRealtimeMini20251006 => "gpt-realtime-mini-2025-10-06",
                RealtimeSessionCreateRequestGAModel.GptRealtimeMini20251215 => "gpt-realtime-mini-2025-12-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestGAModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-realtime-preview" => RealtimeSessionCreateRequestGAModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestGAModel.Gpt4oMiniRealtimePreview20241217,
                "gpt-4o-realtime-preview" => RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-realtime-preview-2025-06-03" => RealtimeSessionCreateRequestGAModel.Gpt4oRealtimePreview20250603,
                "gpt-audio-1.5" => RealtimeSessionCreateRequestGAModel.GptAudio15,
                "gpt-audio-mini" => RealtimeSessionCreateRequestGAModel.GptAudioMini,
                "gpt-audio-mini-2025-10-06" => RealtimeSessionCreateRequestGAModel.GptAudioMini20251006,
                "gpt-audio-mini-2025-12-15" => RealtimeSessionCreateRequestGAModel.GptAudioMini20251215,
                "gpt-realtime" => RealtimeSessionCreateRequestGAModel.GptRealtime,
                "gpt-realtime-1.5" => RealtimeSessionCreateRequestGAModel.GptRealtime15,
                "gpt-realtime-2025-08-28" => RealtimeSessionCreateRequestGAModel.GptRealtime20250828,
                "gpt-realtime-mini" => RealtimeSessionCreateRequestGAModel.GptRealtimeMini,
                "gpt-realtime-mini-2025-10-06" => RealtimeSessionCreateRequestGAModel.GptRealtimeMini20251006,
                "gpt-realtime-mini-2025-12-15" => RealtimeSessionCreateRequestGAModel.GptRealtimeMini20251215,
                _ => null,
            };
        }
    }
}