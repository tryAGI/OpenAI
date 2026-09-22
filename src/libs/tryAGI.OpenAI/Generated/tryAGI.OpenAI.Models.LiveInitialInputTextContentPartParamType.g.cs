
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text content type. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum LiveInitialInputTextContentPartParamType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialInputTextContentPartParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialInputTextContentPartParamType value)
        {
            return value switch
            {
                LiveInitialInputTextContentPartParamType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialInputTextContentPartParamType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => LiveInitialInputTextContentPartParamType.InputText,
                _ => null,
            };
        }
    }
}