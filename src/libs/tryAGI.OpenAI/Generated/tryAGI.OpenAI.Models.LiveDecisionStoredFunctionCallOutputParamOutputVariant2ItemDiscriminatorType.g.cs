
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType
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
    public static class LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => LiveDecisionStoredFunctionCallOutputParamOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}