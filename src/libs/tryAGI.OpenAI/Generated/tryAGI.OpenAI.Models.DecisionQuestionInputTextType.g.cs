
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_text
    /// </summary>
    public enum DecisionQuestionInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DecisionQuestionInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionQuestionInputTextType value)
        {
            return value switch
            {
                DecisionQuestionInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionQuestionInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => DecisionQuestionInputTextType.InputText,
                _ => null,
            };
        }
    }
}