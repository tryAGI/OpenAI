
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_image
    /// </summary>
    public enum DecisionQuestionInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionQuestionInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionQuestionInputImageType value)
        {
            return value switch
            {
                DecisionQuestionInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionQuestionInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => DecisionQuestionInputImageType.InputImage,
                _ => null,
            };
        }
    }
}