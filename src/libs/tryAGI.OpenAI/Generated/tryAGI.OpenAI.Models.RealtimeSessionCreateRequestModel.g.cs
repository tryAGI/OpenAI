
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptRealtime,
        /// <summary>
        /// 
        /// </summary>
        GptRealtime20250828,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oRealtime,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniRealtime,
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
        Gpt4oMiniRealtimePreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniRealtimePreview20241217,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeSessionCreateRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateRequestModel value)
        {
            return value switch
            {
                RealtimeSessionCreateRequestModel.GptRealtime => "gpt-realtime",
                RealtimeSessionCreateRequestModel.GptRealtime20250828 => "gpt-realtime-2025-08-28",
                RealtimeSessionCreateRequestModel.Gpt4oRealtime => "gpt-4o-realtime",
                RealtimeSessionCreateRequestModel.Gpt4oMiniRealtime => "gpt-4o-mini-realtime",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20250603 => "gpt-4o-realtime-preview-2025-06-03",
                RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime" => RealtimeSessionCreateRequestModel.GptRealtime,
                "gpt-realtime-2025-08-28" => RealtimeSessionCreateRequestModel.GptRealtime20250828,
                "gpt-4o-realtime" => RealtimeSessionCreateRequestModel.Gpt4oRealtime,
                "gpt-4o-mini-realtime" => RealtimeSessionCreateRequestModel.Gpt4oMiniRealtime,
                "gpt-4o-realtime-preview" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-realtime-preview-2025-06-03" => RealtimeSessionCreateRequestModel.Gpt4oRealtimePreview20250603,
                "gpt-4o-mini-realtime-preview" => RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionCreateRequestModel.Gpt4oMiniRealtimePreview20241217,
                _ => null,
            };
        }
    }
}