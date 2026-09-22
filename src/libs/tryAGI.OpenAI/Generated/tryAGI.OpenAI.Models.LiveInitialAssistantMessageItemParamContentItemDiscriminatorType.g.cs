
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum LiveInitialAssistantMessageItemParamContentItemDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialAssistantMessageItemParamContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialAssistantMessageItemParamContentItemDiscriminatorType value)
        {
            return value switch
            {
                LiveInitialAssistantMessageItemParamContentItemDiscriminatorType.OutputText => "output_text",
                LiveInitialAssistantMessageItemParamContentItemDiscriminatorType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialAssistantMessageItemParamContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => LiveInitialAssistantMessageItemParamContentItemDiscriminatorType.OutputText,
                "text" => LiveInitialAssistantMessageItemParamContentItemDiscriminatorType.Text,
                _ => null,
            };
        }
    }
}