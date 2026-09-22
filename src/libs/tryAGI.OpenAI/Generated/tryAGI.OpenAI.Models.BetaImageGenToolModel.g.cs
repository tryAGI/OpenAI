
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
    public enum BetaImageGenToolModel
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
    public static class BetaImageGenToolModelExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolModel value)
        {
            return value switch
            {
                BetaImageGenToolModel.GptImage1 => "gpt-image-1",
                BetaImageGenToolModel.GptImage1Mini => "gpt-image-1-mini",
                BetaImageGenToolModel.GptImage15 => "gpt-image-1.5",
                BetaImageGenToolModel.GptImage2 => "gpt-image-2",
                BetaImageGenToolModel.GptImage220260421 => "gpt-image-2-2026-04-21",
                BetaImageGenToolModel.GptImage25Flare => "gpt-image-2.5-flare",
                BetaImageGenToolModel.GptImage25Flare20260908 => "gpt-image-2.5-flare-2026-09-08",
                BetaImageGenToolModel.GptImage25Sunburst => "gpt-image-2.5-sunburst",
                BetaImageGenToolModel.GptImage25Sunburst20260908 => "gpt-image-2.5-sunburst-2026-09-08",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolModel? ToEnum(string value)
        {
            return value switch
            {
                "gpt-image-1" => BetaImageGenToolModel.GptImage1,
                "gpt-image-1-mini" => BetaImageGenToolModel.GptImage1Mini,
                "gpt-image-1.5" => BetaImageGenToolModel.GptImage15,
                "gpt-image-2" => BetaImageGenToolModel.GptImage2,
                "gpt-image-2-2026-04-21" => BetaImageGenToolModel.GptImage220260421,
                "gpt-image-2.5-flare" => BetaImageGenToolModel.GptImage25Flare,
                "gpt-image-2.5-flare-2026-09-08" => BetaImageGenToolModel.GptImage25Flare20260908,
                "gpt-image-2.5-sunburst" => BetaImageGenToolModel.GptImage25Sunburst,
                "gpt-image-2.5-sunburst-2026-09-08" => BetaImageGenToolModel.GptImage25Sunburst20260908,
                _ => null,
            };
        }
    }
}