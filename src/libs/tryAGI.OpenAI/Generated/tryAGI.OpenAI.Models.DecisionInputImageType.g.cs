
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_image
    /// </summary>
    public enum DecisionInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputImageType value)
        {
            return value switch
            {
                DecisionInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => DecisionInputImageType.InputImage,
                _ => null,
            };
        }
    }
}