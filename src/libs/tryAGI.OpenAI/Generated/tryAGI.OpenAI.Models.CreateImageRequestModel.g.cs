
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum CreateImageRequestModel
    {
        /// <summary>
        /// 
        /// </summary>
        GptImage15,
        /// <summary>
        /// 
        /// </summary>
        DallE2,
        /// <summary>
        /// 
        /// </summary>
        DallE3,
        /// <summary>
        /// 
        /// </summary>
        GptImage1,
        /// <summary>
        /// 
        /// </summary>
        GptImage1Mini,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class CreateImageRequestModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this CreateImageRequestModel value)
        {
            return value switch
            {
                CreateImageRequestModel.GptImage15 => "gpt-image-1.5",
                CreateImageRequestModel.DallE2 => "dall-e-2",
                CreateImageRequestModel.DallE3 => "dall-e-3",
                CreateImageRequestModel.GptImage1 => "gpt-image-1",
                CreateImageRequestModel.GptImage1Mini => "gpt-image-1-mini",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static CreateImageRequestModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-1.5" => CreateImageRequestModel.GptImage15,
                "dall-e-2" => CreateImageRequestModel.DallE2,
                "dall-e-3" => CreateImageRequestModel.DallE3,
                "gpt-image-1" => CreateImageRequestModel.GptImage1,
                "gpt-image-1-mini" => CreateImageRequestModel.GptImage1Mini,
                _ => null,
            };
        }
    }
}