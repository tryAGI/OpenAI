
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType
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
    public static class LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson => "input_json",
                LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage,
                "input_json" => LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson,
                "input_text" => LiveDecisionPredicateQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}