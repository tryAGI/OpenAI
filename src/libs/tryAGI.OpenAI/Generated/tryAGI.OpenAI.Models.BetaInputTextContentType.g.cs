
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum BetaInputTextContentType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaInputTextContentTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaInputTextContentType value)
        {
            return value switch
            {
                BetaInputTextContentType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaInputTextContentType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => BetaInputTextContentType.InputText,
                _ => null,
            };
        }
    }
}