
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType
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
    public static class LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType.InputImage,
                "input_text" => LiveDecisionStoredInputItemParamContentVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}