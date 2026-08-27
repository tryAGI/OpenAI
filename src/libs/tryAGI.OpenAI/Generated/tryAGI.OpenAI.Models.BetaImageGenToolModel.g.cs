
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The image generation model to use. Default: `gpt-image-1`.<br/>
    /// Default Value: gpt-image-1
    /// </summary>
    public enum BetaImageGenToolModel
    {
        /// <summary>
        /// `gpt-image-1`.
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
                _ => null,
            };
        }
    }
}