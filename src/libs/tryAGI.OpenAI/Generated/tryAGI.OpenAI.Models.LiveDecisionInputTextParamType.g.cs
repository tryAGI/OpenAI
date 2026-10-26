
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: input_text
    /// </summary>
    public enum LiveDecisionInputTextParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveDecisionInputTextParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveDecisionInputTextParamType value)
        {
            return value switch
            {
                LiveDecisionInputTextParamType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveDecisionInputTextParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => LiveDecisionInputTextParamType.InputText,
                _ => null,
            };
        }
    }
}