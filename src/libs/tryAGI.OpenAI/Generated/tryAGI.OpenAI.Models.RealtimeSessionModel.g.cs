
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionModel
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
    public static class RealtimeSessionModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionModel value)
        {
            return value switch
            {
                RealtimeSessionModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                RealtimeSessionModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionModel.Gpt4oRealtimePreview20250603 => "gpt-4o-realtime-preview-2025-06-03",
                RealtimeSessionModel.GptAudio15 => "gpt-audio-1.5",
                RealtimeSessionModel.GptAudioMini => "gpt-audio-mini",
                RealtimeSessionModel.GptAudioMini20251006 => "gpt-audio-mini-2025-10-06",
                RealtimeSessionModel.GptAudioMini20251215 => "gpt-audio-mini-2025-12-15",
                RealtimeSessionModel.GptRealtime => "gpt-realtime",
                RealtimeSessionModel.GptRealtime15 => "gpt-realtime-1.5",
                RealtimeSessionModel.GptRealtime20250828 => "gpt-realtime-2025-08-28",
                RealtimeSessionModel.GptRealtimeMini => "gpt-realtime-mini",
                RealtimeSessionModel.GptRealtimeMini20251006 => "gpt-realtime-mini-2025-10-06",
                RealtimeSessionModel.GptRealtimeMini20251215 => "gpt-realtime-mini-2025-12-15",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4o-mini-realtime-preview" => RealtimeSessionModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionModel.Gpt4oMiniRealtimePreview20241217,
                "gpt-4o-realtime-preview" => RealtimeSessionModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-realtime-preview-2025-06-03" => RealtimeSessionModel.Gpt4oRealtimePreview20250603,
                "gpt-audio-1.5" => RealtimeSessionModel.GptAudio15,
                "gpt-audio-mini" => RealtimeSessionModel.GptAudioMini,
                "gpt-audio-mini-2025-10-06" => RealtimeSessionModel.GptAudioMini20251006,
                "gpt-audio-mini-2025-12-15" => RealtimeSessionModel.GptAudioMini20251215,
                "gpt-realtime" => RealtimeSessionModel.GptRealtime,
                "gpt-realtime-1.5" => RealtimeSessionModel.GptRealtime15,
                "gpt-realtime-2025-08-28" => RealtimeSessionModel.GptRealtime20250828,
                "gpt-realtime-mini" => RealtimeSessionModel.GptRealtimeMini,
                "gpt-realtime-mini-2025-10-06" => RealtimeSessionModel.GptRealtimeMini20251006,
                "gpt-realtime-mini-2025-12-15" => RealtimeSessionModel.GptRealtimeMini20251215,
                _ => null,
            };
        }
    }
}