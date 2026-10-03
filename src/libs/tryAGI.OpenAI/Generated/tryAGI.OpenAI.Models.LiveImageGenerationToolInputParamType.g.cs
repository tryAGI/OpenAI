
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: image_generation
    /// </summary>
    public enum LiveImageGenerationToolInputParamType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveImageGenerationToolInputParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveImageGenerationToolInputParamType value)
        {
            return value switch
            {
                LiveImageGenerationToolInputParamType.ImageGeneration => "image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveImageGenerationToolInputParamType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation" => LiveImageGenerationToolInputParamType.ImageGeneration,
                _ => null,
            };
        }
    }
}