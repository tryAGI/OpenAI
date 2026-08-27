
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the image generation tool. Always `image_generation`.
    /// </summary>
    public enum BetaImageGenToolType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaImageGenToolTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaImageGenToolType value)
        {
            return value switch
            {
                BetaImageGenToolType.ImageGeneration => "image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaImageGenToolType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation" => BetaImageGenToolType.ImageGeneration,
                _ => null,
            };
        }
    }
}