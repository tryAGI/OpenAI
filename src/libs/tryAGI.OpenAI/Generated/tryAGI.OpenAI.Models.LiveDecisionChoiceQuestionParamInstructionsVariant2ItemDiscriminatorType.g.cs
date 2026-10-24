
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType
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
    public static class LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson => "input_json",
                LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage,
                "input_json" => LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson,
                "input_text" => LiveDecisionChoiceQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}