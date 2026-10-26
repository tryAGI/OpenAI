
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType
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
    public static class LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => LiveDecisionFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}