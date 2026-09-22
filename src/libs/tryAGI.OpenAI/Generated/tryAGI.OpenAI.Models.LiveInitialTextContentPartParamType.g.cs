
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The text content type. Always `text`.<br/>
    /// Default Value: text
    /// </summary>
    public enum LiveInitialTextContentPartParamType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class LiveInitialTextContentPartParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this LiveInitialTextContentPartParamType value)
        {
            return value switch
            {
                LiveInitialTextContentPartParamType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static LiveInitialTextContentPartParamType? ToEnum(string value)
        {
            return value switch
            {
                "text" => LiveInitialTextContentPartParamType.Text,
                _ => null,
            };
        }
    }
}