
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputContentPartDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputText,
        /// <summary>
        ///
        /// </summary>
        OutputText,
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionInputContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputContentPartDiscriminatorType value)
        {
            return value switch
            {
                DecisionInputContentPartDiscriminatorType.InputImage => "input_image",
                DecisionInputContentPartDiscriminatorType.InputText => "input_text",
                DecisionInputContentPartDiscriminatorType.OutputText => "output_text",
                DecisionInputContentPartDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => DecisionInputContentPartDiscriminatorType.InputImage,
                "input_text" => DecisionInputContentPartDiscriminatorType.InputText,
                "output_text" => DecisionInputContentPartDiscriminatorType.OutputText,
                "refusal" => DecisionInputContentPartDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}