
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ChatModel
    {
        /// <summary>
        /// 
        /// </summary>
        Gpt5,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt520250807,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Mini20250807,
        /// <summary>
        /// 
        /// </summary>
        Gpt5Nano20250807,
        /// <summary>
        /// 
        /// </summary>
        Gpt5ChatLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt41,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano,
        /// <summary>
        /// 
        /// </summary>
        Gpt4120250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Mini20250414,
        /// <summary>
        /// 
        /// </summary>
        Gpt41Nano20250414,
        /// <summary>
        /// 
        /// </summary>
        O4Mini,
        /// <summary>
        /// 
        /// </summary>
        O4Mini20250416,
        /// <summary>
        /// 
        /// </summary>
        O3,
        /// <summary>
        /// 
        /// </summary>
        O320250416,
        /// <summary>
        /// 
        /// </summary>
        O3Mini,
        /// <summary>
        /// 
        /// </summary>
        O3Mini20250131,
        /// <summary>
        /// 
        /// </summary>
        O1,
        /// <summary>
        /// 
        /// </summary>
        O120241217,
        /// <summary>
        /// 
        /// </summary>
        O1Preview,
        /// <summary>
        /// 
        /// </summary>
        O1Preview20240912,
        /// <summary>
        /// 
        /// </summary>
        O1Mini,
        /// <summary>
        /// 
        /// </summary>
        O1Mini20240912,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20241120,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240806,
        /// <summary>
        /// 
        /// </summary>
        Gpt4o20240513,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20241001,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oAudioPreview20250603,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview20241217,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniSearchPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oSearchPreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniSearchPreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt4oLatest,
        /// <summary>
        /// 
        /// </summary>
        CodexMiniLatest,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt4Turbo20240409,
        /// <summary>
        /// 
        /// </summary>
        Gpt40125Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4TurboPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt41106Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4VisionPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4,
        /// <summary>
        /// 
        /// </summary>
        Gpt40314,
        /// <summary>
        /// 
        /// </summary>
        Gpt40613,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k0314,
        /// <summary>
        /// 
        /// </summary>
        Gpt432k0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0301,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0613,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo1106,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo0125,
        /// <summary>
        /// 
        /// </summary>
        Gpt35Turbo16k0613,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ChatModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ChatModel value)
        {
            return value switch
            {
                ChatModel.Gpt5 => "gpt-5",
                ChatModel.Gpt5Mini => "gpt-5-mini",
                ChatModel.Gpt5Nano => "gpt-5-nano",
                ChatModel.Gpt520250807 => "gpt-5-2025-08-07",
                ChatModel.Gpt5Mini20250807 => "gpt-5-mini-2025-08-07",
                ChatModel.Gpt5Nano20250807 => "gpt-5-nano-2025-08-07",
                ChatModel.Gpt5ChatLatest => "gpt-5-chat-latest",
                ChatModel.Gpt41 => "gpt-4.1",
                ChatModel.Gpt41Mini => "gpt-4.1-mini",
                ChatModel.Gpt41Nano => "gpt-4.1-nano",
                ChatModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                ChatModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                ChatModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                ChatModel.O4Mini => "o4-mini",
                ChatModel.O4Mini20250416 => "o4-mini-2025-04-16",
                ChatModel.O3 => "o3",
                ChatModel.O320250416 => "o3-2025-04-16",
                ChatModel.O3Mini => "o3-mini",
                ChatModel.O3Mini20250131 => "o3-mini-2025-01-31",
                ChatModel.O1 => "o1",
                ChatModel.O120241217 => "o1-2024-12-17",
                ChatModel.O1Preview => "o1-preview",
                ChatModel.O1Preview20240912 => "o1-preview-2024-09-12",
                ChatModel.O1Mini => "o1-mini",
                ChatModel.O1Mini20240912 => "o1-mini-2024-09-12",
                ChatModel.Gpt4o => "gpt-4o",
                ChatModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                ChatModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                ChatModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                ChatModel.Gpt4oAudioPreview => "gpt-4o-audio-preview",
                ChatModel.Gpt4oAudioPreview20241001 => "gpt-4o-audio-preview-2024-10-01",
                ChatModel.Gpt4oAudioPreview20241217 => "gpt-4o-audio-preview-2024-12-17",
                ChatModel.Gpt4oAudioPreview20250603 => "gpt-4o-audio-preview-2025-06-03",
                ChatModel.Gpt4oMiniAudioPreview => "gpt-4o-mini-audio-preview",
                ChatModel.Gpt4oMiniAudioPreview20241217 => "gpt-4o-mini-audio-preview-2024-12-17",
                ChatModel.Gpt4oSearchPreview => "gpt-4o-search-preview",
                ChatModel.Gpt4oMiniSearchPreview => "gpt-4o-mini-search-preview",
                ChatModel.Gpt4oSearchPreview20250311 => "gpt-4o-search-preview-2025-03-11",
                ChatModel.Gpt4oMiniSearchPreview20250311 => "gpt-4o-mini-search-preview-2025-03-11",
                ChatModel.Chatgpt4oLatest => "chatgpt-4o-latest",
                ChatModel.CodexMiniLatest => "codex-mini-latest",
                ChatModel.Gpt4oMini => "gpt-4o-mini",
                ChatModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                ChatModel.Gpt4Turbo => "gpt-4-turbo",
                ChatModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                ChatModel.Gpt40125Preview => "gpt-4-0125-preview",
                ChatModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                ChatModel.Gpt41106Preview => "gpt-4-1106-preview",
                ChatModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                ChatModel.Gpt4 => "gpt-4",
                ChatModel.Gpt40314 => "gpt-4-0314",
                ChatModel.Gpt40613 => "gpt-4-0613",
                ChatModel.Gpt432k => "gpt-4-32k",
                ChatModel.Gpt432k0314 => "gpt-4-32k-0314",
                ChatModel.Gpt432k0613 => "gpt-4-32k-0613",
                ChatModel.Gpt35Turbo => "gpt-3.5-turbo",
                ChatModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                ChatModel.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                ChatModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                ChatModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                ChatModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                ChatModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ChatModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-5" => ChatModel.Gpt5,
                "gpt-5-mini" => ChatModel.Gpt5Mini,
                "gpt-5-nano" => ChatModel.Gpt5Nano,
                "gpt-5-2025-08-07" => ChatModel.Gpt520250807,
                "gpt-5-mini-2025-08-07" => ChatModel.Gpt5Mini20250807,
                "gpt-5-nano-2025-08-07" => ChatModel.Gpt5Nano20250807,
                "gpt-5-chat-latest" => ChatModel.Gpt5ChatLatest,
                "gpt-4.1" => ChatModel.Gpt41,
                "gpt-4.1-mini" => ChatModel.Gpt41Mini,
                "gpt-4.1-nano" => ChatModel.Gpt41Nano,
                "gpt-4.1-2025-04-14" => ChatModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => ChatModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => ChatModel.Gpt41Nano20250414,
                "o4-mini" => ChatModel.O4Mini,
                "o4-mini-2025-04-16" => ChatModel.O4Mini20250416,
                "o3" => ChatModel.O3,
                "o3-2025-04-16" => ChatModel.O320250416,
                "o3-mini" => ChatModel.O3Mini,
                "o3-mini-2025-01-31" => ChatModel.O3Mini20250131,
                "o1" => ChatModel.O1,
                "o1-2024-12-17" => ChatModel.O120241217,
                "o1-preview" => ChatModel.O1Preview,
                "o1-preview-2024-09-12" => ChatModel.O1Preview20240912,
                "o1-mini" => ChatModel.O1Mini,
                "o1-mini-2024-09-12" => ChatModel.O1Mini20240912,
                "gpt-4o" => ChatModel.Gpt4o,
                "gpt-4o-2024-11-20" => ChatModel.Gpt4o20241120,
                "gpt-4o-2024-08-06" => ChatModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => ChatModel.Gpt4o20240513,
                "gpt-4o-audio-preview" => ChatModel.Gpt4oAudioPreview,
                "gpt-4o-audio-preview-2024-10-01" => ChatModel.Gpt4oAudioPreview20241001,
                "gpt-4o-audio-preview-2024-12-17" => ChatModel.Gpt4oAudioPreview20241217,
                "gpt-4o-audio-preview-2025-06-03" => ChatModel.Gpt4oAudioPreview20250603,
                "gpt-4o-mini-audio-preview" => ChatModel.Gpt4oMiniAudioPreview,
                "gpt-4o-mini-audio-preview-2024-12-17" => ChatModel.Gpt4oMiniAudioPreview20241217,
                "gpt-4o-search-preview" => ChatModel.Gpt4oSearchPreview,
                "gpt-4o-mini-search-preview" => ChatModel.Gpt4oMiniSearchPreview,
                "gpt-4o-search-preview-2025-03-11" => ChatModel.Gpt4oSearchPreview20250311,
                "gpt-4o-mini-search-preview-2025-03-11" => ChatModel.Gpt4oMiniSearchPreview20250311,
                "chatgpt-4o-latest" => ChatModel.Chatgpt4oLatest,
                "codex-mini-latest" => ChatModel.CodexMiniLatest,
                "gpt-4o-mini" => ChatModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => ChatModel.Gpt4oMini20240718,
                "gpt-4-turbo" => ChatModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => ChatModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => ChatModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => ChatModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => ChatModel.Gpt41106Preview,
                "gpt-4-vision-preview" => ChatModel.Gpt4VisionPreview,
                "gpt-4" => ChatModel.Gpt4,
                "gpt-4-0314" => ChatModel.Gpt40314,
                "gpt-4-0613" => ChatModel.Gpt40613,
                "gpt-4-32k" => ChatModel.Gpt432k,
                "gpt-4-32k-0314" => ChatModel.Gpt432k0314,
                "gpt-4-32k-0613" => ChatModel.Gpt432k0613,
                "gpt-3.5-turbo" => ChatModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => ChatModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => ChatModel.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => ChatModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => ChatModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => ChatModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => ChatModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}