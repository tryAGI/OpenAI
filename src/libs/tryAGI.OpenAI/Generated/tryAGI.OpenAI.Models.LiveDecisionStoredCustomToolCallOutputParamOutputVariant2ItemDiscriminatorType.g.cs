
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType
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
    public static class LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType.InputImage,
                "input_text" => LiveDecisionStoredCustomToolCallOutputParamOutputVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}