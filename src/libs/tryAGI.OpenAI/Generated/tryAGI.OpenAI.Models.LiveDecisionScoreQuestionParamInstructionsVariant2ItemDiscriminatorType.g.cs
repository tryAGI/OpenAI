
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType
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
    public static class LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson => "input_json",
                LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputImage,
                "input_json" => LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputJson,
                "input_text" => LiveDecisionScoreQuestionParamInstructionsVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}