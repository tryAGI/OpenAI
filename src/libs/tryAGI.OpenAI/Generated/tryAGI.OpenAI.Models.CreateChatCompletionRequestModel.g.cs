
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateChatCompletionRequestModel
    {
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
        Gpt4oMiniAudioPreview,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMiniAudioPreview20241217,
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
    public static class CreateChatCompletionRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateChatCompletionRequestModel value)
        {
            return value switch
            {
                CreateChatCompletionRequestModel.O3Mini => "o3-mini",
                CreateChatCompletionRequestModel.O3Mini20250131 => "o3-mini-2025-01-31",
                CreateChatCompletionRequestModel.O1 => "o1",
                CreateChatCompletionRequestModel.O120241217 => "o1-2024-12-17",
                CreateChatCompletionRequestModel.O1Preview => "o1-preview",
                CreateChatCompletionRequestModel.O1Preview20240912 => "o1-preview-2024-09-12",
                CreateChatCompletionRequestModel.O1Mini => "o1-mini",
                CreateChatCompletionRequestModel.O1Mini20240912 => "o1-mini-2024-09-12",
                CreateChatCompletionRequestModel.Gpt4o => "gpt-4o",
                CreateChatCompletionRequestModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                CreateChatCompletionRequestModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                CreateChatCompletionRequestModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                CreateChatCompletionRequestModel.Gpt4oAudioPreview => "gpt-4o-audio-preview",
                CreateChatCompletionRequestModel.Gpt4oAudioPreview20241001 => "gpt-4o-audio-preview-2024-10-01",
                CreateChatCompletionRequestModel.Gpt4oAudioPreview20241217 => "gpt-4o-audio-preview-2024-12-17",
                CreateChatCompletionRequestModel.Gpt4oMiniAudioPreview => "gpt-4o-mini-audio-preview",
                CreateChatCompletionRequestModel.Gpt4oMiniAudioPreview20241217 => "gpt-4o-mini-audio-preview-2024-12-17",
                CreateChatCompletionRequestModel.Chatgpt4oLatest => "chatgpt-4o-latest",
                CreateChatCompletionRequestModel.Gpt4oMini => "gpt-4o-mini",
                CreateChatCompletionRequestModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                CreateChatCompletionRequestModel.Gpt4Turbo => "gpt-4-turbo",
                CreateChatCompletionRequestModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateChatCompletionRequestModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateChatCompletionRequestModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateChatCompletionRequestModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateChatCompletionRequestModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateChatCompletionRequestModel.Gpt4 => "gpt-4",
                CreateChatCompletionRequestModel.Gpt40314 => "gpt-4-0314",
                CreateChatCompletionRequestModel.Gpt40613 => "gpt-4-0613",
                CreateChatCompletionRequestModel.Gpt432k => "gpt-4-32k",
                CreateChatCompletionRequestModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateChatCompletionRequestModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateChatCompletionRequestModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateChatCompletionRequestModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateChatCompletionRequestModel.Gpt35Turbo0301 => "gpt-3.5-turbo-0301",
                CreateChatCompletionRequestModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateChatCompletionRequestModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateChatCompletionRequestModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateChatCompletionRequestModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateChatCompletionRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "o3-mini" => CreateChatCompletionRequestModel.O3Mini,
                "o3-mini-2025-01-31" => CreateChatCompletionRequestModel.O3Mini20250131,
                "o1" => CreateChatCompletionRequestModel.O1,
                "o1-2024-12-17" => CreateChatCompletionRequestModel.O120241217,
                "o1-preview" => CreateChatCompletionRequestModel.O1Preview,
                "o1-preview-2024-09-12" => CreateChatCompletionRequestModel.O1Preview20240912,
                "o1-mini" => CreateChatCompletionRequestModel.O1Mini,
                "o1-mini-2024-09-12" => CreateChatCompletionRequestModel.O1Mini20240912,
                "gpt-4o" => CreateChatCompletionRequestModel.Gpt4o,
                "gpt-4o-2024-11-20" => CreateChatCompletionRequestModel.Gpt4o20241120,
                "gpt-4o-2024-08-06" => CreateChatCompletionRequestModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => CreateChatCompletionRequestModel.Gpt4o20240513,
                "gpt-4o-audio-preview" => CreateChatCompletionRequestModel.Gpt4oAudioPreview,
                "gpt-4o-audio-preview-2024-10-01" => CreateChatCompletionRequestModel.Gpt4oAudioPreview20241001,
                "gpt-4o-audio-preview-2024-12-17" => CreateChatCompletionRequestModel.Gpt4oAudioPreview20241217,
                "gpt-4o-mini-audio-preview" => CreateChatCompletionRequestModel.Gpt4oMiniAudioPreview,
                "gpt-4o-mini-audio-preview-2024-12-17" => CreateChatCompletionRequestModel.Gpt4oMiniAudioPreview20241217,
                "chatgpt-4o-latest" => CreateChatCompletionRequestModel.Chatgpt4oLatest,
                "gpt-4o-mini" => CreateChatCompletionRequestModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => CreateChatCompletionRequestModel.Gpt4oMini20240718,
                "gpt-4-turbo" => CreateChatCompletionRequestModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateChatCompletionRequestModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateChatCompletionRequestModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateChatCompletionRequestModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateChatCompletionRequestModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateChatCompletionRequestModel.Gpt4VisionPreview,
                "gpt-4" => CreateChatCompletionRequestModel.Gpt4,
                "gpt-4-0314" => CreateChatCompletionRequestModel.Gpt40314,
                "gpt-4-0613" => CreateChatCompletionRequestModel.Gpt40613,
                "gpt-4-32k" => CreateChatCompletionRequestModel.Gpt432k,
                "gpt-4-32k-0314" => CreateChatCompletionRequestModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateChatCompletionRequestModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateChatCompletionRequestModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateChatCompletionRequestModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0301" => CreateChatCompletionRequestModel.Gpt35Turbo0301,
                "gpt-3.5-turbo-0613" => CreateChatCompletionRequestModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateChatCompletionRequestModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateChatCompletionRequestModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateChatCompletionRequestModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}