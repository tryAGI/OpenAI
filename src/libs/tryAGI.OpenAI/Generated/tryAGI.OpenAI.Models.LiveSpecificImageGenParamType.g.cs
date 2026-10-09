
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The tool to call. Always `image_generation`.<br/>
    /// Default Value: image_generation
    /// </summary>
    public enum LiveSpecificImageGenParamType
    {
        /// <summary>
        ///
        /// </summary>
        ImageGeneration,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveSpecificImageGenParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveSpecificImageGenParamType value)
        {
            return value switch
            {
                LiveSpecificImageGenParamType.ImageGeneration => "image_generation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveSpecificImageGenParamType? ToEnum(string value)
        {
            return value switch
            {
                "image_generation" => LiveSpecificImageGenParamType.ImageGeneration,
                _ => null,
            };
        }
    }
}