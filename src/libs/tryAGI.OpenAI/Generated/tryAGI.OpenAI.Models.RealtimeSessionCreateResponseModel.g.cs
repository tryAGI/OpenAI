
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum RealtimeSessionCreateResponseModel
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
    public static class RealtimeSessionCreateResponseModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeSessionCreateResponseModel value)
        {
            return value switch
            {
                RealtimeSessionCreateResponseModel.GptRealtime => "gpt-realtime",
                RealtimeSessionCreateResponseModel.GptRealtime20250828 => "gpt-realtime-2025-08-28",
                RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview => "gpt-4o-realtime-preview",
                RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20241001 => "gpt-4o-realtime-preview-2024-10-01",
                RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20241217 => "gpt-4o-realtime-preview-2024-12-17",
                RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20250603 => "gpt-4o-realtime-preview-2025-06-03",
                RealtimeSessionCreateResponseModel.Gpt4oMiniRealtimePreview => "gpt-4o-mini-realtime-preview",
                RealtimeSessionCreateResponseModel.Gpt4oMiniRealtimePreview20241217 => "gpt-4o-mini-realtime-preview-2024-12-17",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeSessionCreateResponseModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-realtime" => RealtimeSessionCreateResponseModel.GptRealtime,
                "gpt-realtime-2025-08-28" => RealtimeSessionCreateResponseModel.GptRealtime20250828,
                "gpt-4o-realtime-preview" => RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview,
                "gpt-4o-realtime-preview-2024-10-01" => RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20241001,
                "gpt-4o-realtime-preview-2024-12-17" => RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20241217,
                "gpt-4o-realtime-preview-2025-06-03" => RealtimeSessionCreateResponseModel.Gpt4oRealtimePreview20250603,
                "gpt-4o-mini-realtime-preview" => RealtimeSessionCreateResponseModel.Gpt4oMiniRealtimePreview,
                "gpt-4o-mini-realtime-preview-2024-12-17" => RealtimeSessionCreateResponseModel.Gpt4oMiniRealtimePreview20241217,
                _ => null,
            };
        }
    }
}