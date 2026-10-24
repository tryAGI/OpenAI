
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType
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
    public static class LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType value)
        {
            return value switch
            {
                LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType.OutputText => "output_text",
                LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType.OutputText,
                "refusal" => LiveDecisionStoredAssistantMessageParamContentVariant2ItemDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}