
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text content type. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum LiveInitialOutputTextContentPartParamType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialOutputTextContentPartParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialOutputTextContentPartParamType value)
        {
            return value switch
            {
                LiveInitialOutputTextContentPartParamType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialOutputTextContentPartParamType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => LiveInitialOutputTextContentPartParamType.OutputText,
                _ => null,
            };
        }
    }
}