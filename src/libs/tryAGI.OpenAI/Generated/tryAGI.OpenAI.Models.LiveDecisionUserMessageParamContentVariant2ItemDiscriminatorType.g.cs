
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType
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
    public static class LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputImage => "input_image",
                LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputJson => "input_json",
                LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputImage,
                "input_json" => LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputJson,
                "input_text" => LiveDecisionUserMessageParamContentVariant2ItemDiscriminatorType.InputText,
                _ => null,
            };
        }
    }
}