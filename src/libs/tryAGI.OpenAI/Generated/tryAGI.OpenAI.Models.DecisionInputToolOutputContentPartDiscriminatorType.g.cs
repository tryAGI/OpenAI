
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputToolOutputContentPartDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputToolOutputContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputToolOutputContentPartDiscriminatorType value)
        {
            return value switch
            {
                DecisionInputToolOutputContentPartDiscriminatorType.InputImage => "input_image",
                DecisionInputToolOutputContentPartDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputToolOutputContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => DecisionInputToolOutputContentPartDiscriminatorType.InputImage,
                "input_text" => DecisionInputToolOutputContentPartDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}