
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum CreateImageEditRequestModel
    {
        /// <summary>
        ///
        /// </summary>
        ChatgptImageLatest,
        /// <summary>
        ///
        /// </summary>
        DallE2,
        /// <summary>
        ///
        /// </summary>
        GptImage1,
        /// <summary>
        ///
        /// </summary>
        GptImage1Mini,
        /// <summary>
        ///
        /// </summary>
        GptImage15,
        /// <summary>
        ///
        /// </summary>
        GptImage2,
        /// <summary>
        ///
        /// </summary>
        GptImage220260421,
        /// <summary>
        ///
        /// </summary>
        GptImage25Flare,
        /// <summary>
        ///
        /// </summary>
        GptImage25Flare20260908,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst,
        /// <summary>
        ///
        /// </summary>
        GptImage25Sunburst20260908,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageEditRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageEditRequestModel value)
        {
            return value switch
            {
                CreateImageEditRequestModel.ChatgptImageLatest => "chatgpt-image-latest",
                CreateImageEditRequestModel.DallE2 => "dall-e-2",
                CreateImageEditRequestModel.GptImage1 => "gpt-image-1",
                CreateImageEditRequestModel.GptImage1Mini => "gpt-image-1-mini",
                CreateImageEditRequestModel.GptImage15 => "gpt-image-1.5",
                CreateImageEditRequestModel.GptImage2 => "gpt-image-2",
                CreateImageEditRequestModel.GptImage220260421 => "gpt-image-2-2026-04-21",
                CreateImageEditRequestModel.GptImage25Flare => "gpt-image-2.5-flare",
                CreateImageEditRequestModel.GptImage25Flare20260908 => "gpt-image-2.5-flare-2026-09-08",
                CreateImageEditRequestModel.GptImage25Sunburst => "gpt-image-2.5-sunburst",
                CreateImageEditRequestModel.GptImage25Sunburst20260908 => "gpt-image-2.5-sunburst-2026-09-08",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageEditRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "chatgpt-image-latest" => CreateImageEditRequestModel.ChatgptImageLatest,
                "dall-e-2" => CreateImageEditRequestModel.DallE2,
                "gpt-image-1" => CreateImageEditRequestModel.GptImage1,
                "gpt-image-1-mini" => CreateImageEditRequestModel.GptImage1Mini,
                "gpt-image-1.5" => CreateImageEditRequestModel.GptImage15,
                "gpt-image-2" => CreateImageEditRequestModel.GptImage2,
                "gpt-image-2-2026-04-21" => CreateImageEditRequestModel.GptImage220260421,
                "gpt-image-2.5-flare" => CreateImageEditRequestModel.GptImage25Flare,
                "gpt-image-2.5-flare-2026-09-08" => CreateImageEditRequestModel.GptImage25Flare20260908,
                "gpt-image-2.5-sunburst" => CreateImageEditRequestModel.GptImage25Sunburst,
                "gpt-image-2.5-sunburst-2026-09-08" => CreateImageEditRequestModel.GptImage25Sunburst20260908,
                _ => null,
            };
        }
    }
}