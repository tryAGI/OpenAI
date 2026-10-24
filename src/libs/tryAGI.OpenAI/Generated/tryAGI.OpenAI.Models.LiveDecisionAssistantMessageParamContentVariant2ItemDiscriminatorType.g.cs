
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
        /// <summary>
        ///
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType.OutputText => "output_text",
                LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType.OutputText,
                "refusal" => LiveDecisionAssistantMessageParamContentVariant2ItemDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}