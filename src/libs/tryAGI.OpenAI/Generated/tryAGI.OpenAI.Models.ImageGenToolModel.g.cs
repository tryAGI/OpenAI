
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The image generation model to use. One of `gpt-image-1`,<br/>
    /// `gpt-image-1-mini`, `gpt-image-1.5`, `gpt-image-2`,<br/>
    /// `gpt-image-2-2026-04-21`, `gpt-image-2.5-sunburst`,<br/>
    /// `gpt-image-2.5-sunburst-2026-09-08`, `gpt-image-2.5-flare`,<br/>
    /// `gpt-image-2.5-flare-2026-09-08`, or `chatgpt-image-latest`. Default:<br/>
    /// `gpt-image-1`.<br/>
    /// Default Value: gpt-image-1
    /// </summary>
    public enum ImageGenToolModel
    {
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
    public static class ImageGenToolModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ImageGenToolModel value)
        {
            return value switch
            {
                ImageGenToolModel.GptImage1 => "gpt-image-1",
                ImageGenToolModel.GptImage1Mini => "gpt-image-1-mini",
                ImageGenToolModel.GptImage15 => "gpt-image-1.5",
                ImageGenToolModel.GptImage2 => "gpt-image-2",
                ImageGenToolModel.GptImage220260421 => "gpt-image-2-2026-04-21",
                ImageGenToolModel.GptImage25Flare => "gpt-image-2.5-flare",
                ImageGenToolModel.GptImage25Flare20260908 => "gpt-image-2.5-flare-2026-09-08",
                ImageGenToolModel.GptImage25Sunburst => "gpt-image-2.5-sunburst",
                ImageGenToolModel.GptImage25Sunburst20260908 => "gpt-image-2.5-sunburst-2026-09-08",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ImageGenToolModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-1" => ImageGenToolModel.GptImage1,
                "gpt-image-1-mini" => ImageGenToolModel.GptImage1Mini,
                "gpt-image-1.5" => ImageGenToolModel.GptImage15,
                "gpt-image-2" => ImageGenToolModel.GptImage2,
                "gpt-image-2-2026-04-21" => ImageGenToolModel.GptImage220260421,
                "gpt-image-2.5-flare" => ImageGenToolModel.GptImage25Flare,
                "gpt-image-2.5-flare-2026-09-08" => ImageGenToolModel.GptImage25Flare20260908,
                "gpt-image-2.5-sunburst" => ImageGenToolModel.GptImage25Sunburst,
                "gpt-image-2.5-sunburst-2026-09-08" => ImageGenToolModel.GptImage25Sunburst20260908,
                _ => null,
            };
        }
    }
}