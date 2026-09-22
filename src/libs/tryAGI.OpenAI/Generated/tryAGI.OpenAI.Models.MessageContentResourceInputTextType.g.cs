
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum MessageContentResourceInputTextType
    {
        /// <summary>
        ///
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentResourceInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentResourceInputTextType value)
        {
            return value switch
            {
                MessageContentResourceInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentResourceInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => MessageContentResourceInputTextType.InputText,
                _ => null,
            };
        }
    }
}