
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType
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
    public static class LiveDecisionInputItemParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType.InputImage,
                "input_text" => LiveDecisionInputItemParamContentVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}