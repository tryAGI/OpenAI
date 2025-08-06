
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateThreadAndRunRequestWithoutStreamModel
    {
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
        Gpt4oMini,
        /// <summary>
        /// 
        /// </summary>
        Gpt4oMini20240718,
        /// <summary>
        /// 
        /// </summary>
        Gpt45Preview,
        /// <summary>
        /// 
        /// </summary>
        Gpt45Preview20250227,
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
    public static class CreateThreadAndRunRequestWithoutStreamModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateThreadAndRunRequestWithoutStreamModel value)
        {
            return value switch
            {
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41 => "gpt-4.1",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41Mini => "gpt-4.1-mini",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41Nano => "gpt-4.1-nano",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4120250414 => "gpt-4.1-2025-04-14",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41Mini20250414 => "gpt-4.1-mini-2025-04-14",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41Nano20250414 => "gpt-4.1-nano-2025-04-14",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4o => "gpt-4o",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20241120 => "gpt-4o-2024-11-20",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20240806 => "gpt-4o-2024-08-06",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20240513 => "gpt-4o-2024-05-13",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4oMini => "gpt-4o-mini",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4oMini20240718 => "gpt-4o-mini-2024-07-18",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt45Preview => "gpt-4.5-preview",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt45Preview20250227 => "gpt-4.5-preview-2025-02-27",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4Turbo => "gpt-4-turbo",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4Turbo20240409 => "gpt-4-turbo-2024-04-09",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt40125Preview => "gpt-4-0125-preview",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4TurboPreview => "gpt-4-turbo-preview",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt41106Preview => "gpt-4-1106-preview",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4VisionPreview => "gpt-4-vision-preview",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt4 => "gpt-4",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt40314 => "gpt-4-0314",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt40613 => "gpt-4-0613",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt432k => "gpt-4-32k",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt432k0314 => "gpt-4-32k-0314",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt432k0613 => "gpt-4-32k-0613",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo => "gpt-3.5-turbo",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo16k => "gpt-3.5-turbo-16k",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo0613 => "gpt-3.5-turbo-0613",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo1106 => "gpt-3.5-turbo-1106",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo0125 => "gpt-3.5-turbo-0125",
                CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo16k0613 => "gpt-3.5-turbo-16k-0613",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateThreadAndRunRequestWithoutStreamModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-4.1" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41,
                "gpt-4.1-mini" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41Mini,
                "gpt-4.1-nano" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41Nano,
                "gpt-4.1-2025-04-14" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4120250414,
                "gpt-4.1-mini-2025-04-14" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41Mini20250414,
                "gpt-4.1-nano-2025-04-14" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41Nano20250414,
                "gpt-4o" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4o,
                "gpt-4o-2024-11-20" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20241120,
                "gpt-4o-2024-08-06" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20240806,
                "gpt-4o-2024-05-13" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4o20240513,
                "gpt-4o-mini" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4oMini,
                "gpt-4o-mini-2024-07-18" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4oMini20240718,
                "gpt-4.5-preview" => CreateThreadAndRunRequestWithoutStreamModel.Gpt45Preview,
                "gpt-4.5-preview-2025-02-27" => CreateThreadAndRunRequestWithoutStreamModel.Gpt45Preview20250227,
                "gpt-4-turbo" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4Turbo,
                "gpt-4-turbo-2024-04-09" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4Turbo20240409,
                "gpt-4-0125-preview" => CreateThreadAndRunRequestWithoutStreamModel.Gpt40125Preview,
                "gpt-4-turbo-preview" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4TurboPreview,
                "gpt-4-1106-preview" => CreateThreadAndRunRequestWithoutStreamModel.Gpt41106Preview,
                "gpt-4-vision-preview" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4VisionPreview,
                "gpt-4" => CreateThreadAndRunRequestWithoutStreamModel.Gpt4,
                "gpt-4-0314" => CreateThreadAndRunRequestWithoutStreamModel.Gpt40314,
                "gpt-4-0613" => CreateThreadAndRunRequestWithoutStreamModel.Gpt40613,
                "gpt-4-32k" => CreateThreadAndRunRequestWithoutStreamModel.Gpt432k,
                "gpt-4-32k-0314" => CreateThreadAndRunRequestWithoutStreamModel.Gpt432k0314,
                "gpt-4-32k-0613" => CreateThreadAndRunRequestWithoutStreamModel.Gpt432k0613,
                "gpt-3.5-turbo" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo,
                "gpt-3.5-turbo-16k" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo16k,
                "gpt-3.5-turbo-0613" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo0613,
                "gpt-3.5-turbo-1106" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo1106,
                "gpt-3.5-turbo-0125" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo0125,
                "gpt-3.5-turbo-16k-0613" => CreateThreadAndRunRequestWithoutStreamModel.Gpt35Turbo16k0613,
                _ => null,
            };
        }
    }
}