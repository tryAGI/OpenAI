
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ModelIdsEnum
    {
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
        ComputerUsePreview,
        /// <summary>
        /// 
        /// </summary>
        ComputerUsePreview20250311,
        /// <summary>
        /// 
        /// </summary>
        Chatgpt4oLatest,
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
    public static class ModelIdsEnumExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ModelIdsEnum value)
        {
            return value switch
            {
                ModelIdsEnum.O1 => "o1",
                ModelIdsEnum.O120241217 => "o1-2024-12-17",
                ModelIdsEnum.O1Preview => "o1-preview",
                ModelIdsEnum.O1Preview20240912 => "o1-preview-2024-09-12",
                ModelIdsEnum.O1Mini => "o1-mini",
                ModelIdsEnum.O1Mini20240912 => "o1-mini-2024-09-12",
                ModelIdsEnum.Gpt4o => "gpt-4o",
                ModelIdsEnum.Gpt4o20241120 => "gpt-4o-2024-11-20",
                ModelIdsEnum.Gpt4o20240806 => "gpt-4o-2024-08-06",
                ModelIdsEnum.Gpt4o20240513 => "gpt-4o-2024-05-13",
                ModelIdsEnum.Gpt4oAudioPreview => "gpt-4o-audio-preview",
                ModelIdsEnum.Gpt4oAudioPreview20241001 => "gpt-4o-audio-preview-2024-10-01",
                ModelIdsEnum.Gpt4oAudioPreview20241217 => "gpt-4o-audio-preview-2024-12-17",
                ModelIdsEnum.Gpt4oMiniAudioPreview => "gpt-4o-mini-audio-preview",
                ModelIdsEnum.Gpt4oMiniAudioPreview20241217 => "gpt-4o-mini-audio-preview-2024-12-17",
                ModelIdsEnum.Gpt4oSearchPreview => "gpt-4o-search-preview",
                ModelIdsEnum.Gpt4oMiniSearchPreview => "gpt-4o-mini-search-preview",
                ModelIdsEnum.Gpt4oSearchPreview20250311 => "gpt-4o-search-preview-2025-03-11",
                ModelIdsEnum.Gpt4oMiniSearchPreview20250311 => "gpt-4o-mini-search-preview-2025-03-11",
                ModelIdsEnum.ComputerUsePreview => "computer-use-preview",
                ModelIdsEnum.ComputerUsePreview20250311 => "computer-use-preview-2025-03-11",
                ModelIdsEnum.Chatgpt4oLatest => "chatgpt-4o-latest",
                ModelIdsEnum.Gpt4oMini => "gpt-4o-mini",
                ModelIdsEnum.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                ModelIdsEnum.Gpt4Turbo => "gpt-4-turbo",
                ModelIdsEnum.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                ModelIdsEnum.Gpt40125Preview => "gpt-4-0125-preview",
                ModelIdsEnum.Gpt4TurboPreview => "gpt-4-turbo-preview",
                ModelIdsEnum.Gpt41106Preview => "gpt-4-1106-preview",
                ModelIdsEnum.Gpt4VisionPreview => "gpt-4-vision-preview",
                ModelIdsEnum.Gpt4 => "gpt-4",
                ModelIdsEnum.Gpt40314 => "gpt-4-0314",
                ModelIdsEnum.Gpt40613 => "gpt-4-0613",
                ModelIdsEnum.Gpt432k => "gpt-4-32k",
                ModelIdsEnum.Gpt432k0314 => "gpt-4-32k-0314",
                ModelIdsEnum.Gpt432k0613 => "gpt-4-32k-0613",
                ModelIdsEnum.Gpt35Turbo => "gpt-3.5-turbo",
                ModelIdsEnum.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                ModelIdsEnum.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                ModelIdsEnum.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                ModelIdsEnum.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                ModelIdsEnum.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                ModelIdsEnum.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ModelIdsEnum? ToEnum(string value)
        {
            return value switch
            {
                "o1" => ModelIdsEnum.O1,
                "o1-2024-12-17" => ModelIdsEnum.O120241217,
                "o1-preview" => ModelIdsEnum.O1Preview,
                "o1-preview-2024-09-12" => ModelIdsEnum.O1Preview20240912,
                "o1-mini" => ModelIdsEnum.O1Mini,
                "o1-mini-2024-09-12" => ModelIdsEnum.O1Mini20240912,
                "gpt-4o" => ModelIdsEnum.Gpt4o,
                "gpt-4o-2024-11-20" => ModelIdsEnum.Gpt4o20241120,
                "gpt-4o-2024-08-06" => ModelIdsEnum.Gpt4o20240806,
                "gpt-4o-2024-05-13" => ModelIdsEnum.Gpt4o20240513,
                "gpt-4o-audio-preview" => ModelIdsEnum.Gpt4oAudioPreview,
                "gpt-4o-audio-preview-2024-10-01" => ModelIdsEnum.Gpt4oAudioPreview20241001,
                "gpt-4o-audio-preview-2024-12-17" => ModelIdsEnum.Gpt4oAudioPreview20241217,
                "gpt-4o-mini-audio-preview" => ModelIdsEnum.Gpt4oMiniAudioPreview,
                "gpt-4o-mini-audio-preview-2024-12-17" => ModelIdsEnum.Gpt4oMiniAudioPreview20241217,
                "gpt-4o-search-preview" => ModelIdsEnum.Gpt4oSearchPreview,
                "gpt-4o-mini-search-preview" => ModelIdsEnum.Gpt4oMiniSearchPreview,
                "gpt-4o-search-preview-2025-03-11" => ModelIdsEnum.Gpt4oSearchPreview20250311,
                "gpt-4o-mini-search-preview-2025-03-11" => ModelIdsEnum.Gpt4oMiniSearchPreview20250311,
                "computer-use-preview" => ModelIdsEnum.ComputerUsePreview,
                "computer-use-preview-2025-03-11" => ModelIdsEnum.ComputerUsePreview20250311,
                "chatgpt-4o-latest" => ModelIdsEnum.Chatgpt4oLatest,
                "gpt-4o-mini" => ModelIdsEnum.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => ModelIdsEnum.Gpt4oMini20240718,
                "gpt-4-turbo" => ModelIdsEnum.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => ModelIdsEnum.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => ModelIdsEnum.Gpt40125Preview,
                "gpt-4-turbo-preview" => ModelIdsEnum.Gpt4TurboPreview,
                "gpt-4-1106-preview" => ModelIdsEnum.Gpt41106Preview,
                "gpt-4-vision-preview" => ModelIdsEnum.Gpt4VisionPreview,
                "gpt-4" => ModelIdsEnum.Gpt4,
                "gpt-4-0314" => ModelIdsEnum.Gpt40314,
                "gpt-4-0613" => ModelIdsEnum.Gpt40613,
                "gpt-4-32k" => ModelIdsEnum.Gpt432k,
                "gpt-4-32k-0314" => ModelIdsEnum.Gpt432k0314,
                "gpt-4-32k-0613" => ModelIdsEnum.Gpt432k0613,
                "gpt-3.5-turbo" => ModelIdsEnum.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => ModelIdsEnum.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => ModelIdsEnum.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => ModelIdsEnum.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => ModelIdsEnum.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => ModelIdsEnum.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => ModelIdsEnum.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}