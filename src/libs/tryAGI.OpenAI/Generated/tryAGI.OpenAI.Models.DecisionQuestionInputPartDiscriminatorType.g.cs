
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionQuestionInputPartDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputJson,
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionQuestionInputPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionQuestionInputPartDiscriminatorType value)
        {
            return value switch
            {
                DecisionQuestionInputPartDiscriminatorType.InputImage => "input_image",
                DecisionQuestionInputPartDiscriminatorType.InputJson => "input_json",
                DecisionQuestionInputPartDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionQuestionInputPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => DecisionQuestionInputPartDiscriminatorType.InputImage,
                "input_json" => DecisionQuestionInputPartDiscriminatorType.InputJson,
                "input_text" => DecisionQuestionInputPartDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}