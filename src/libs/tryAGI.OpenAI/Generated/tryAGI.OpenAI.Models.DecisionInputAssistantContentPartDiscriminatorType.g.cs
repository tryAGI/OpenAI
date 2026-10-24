
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum DecisionInputAssistantContentPartDiscriminatorType
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
    public static class DecisionInputAssistantContentPartDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DecisionInputAssistantContentPartDiscriminatorType value)
        {
            return value switch
            {
                DecisionInputAssistantContentPartDiscriminatorType.OutputText => "output_text",
                DecisionInputAssistantContentPartDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DecisionInputAssistantContentPartDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => DecisionInputAssistantContentPartDiscriminatorType.OutputText,
                "refusal" => DecisionInputAssistantContentPartDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}