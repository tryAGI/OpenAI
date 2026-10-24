
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType
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
    public static class LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputJson => "input_json",
                LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputImage,
                "input_json" => LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputJson,
                "input_text" => LiveDecisionStoredUserMessageParamContentVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}