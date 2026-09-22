
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `output_text`.<br/>
    /// Default Value: output_text
    /// </summary>
    public enum MessageContentResourceOutputTextType
    {
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentResourceOutputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentResourceOutputTextType value)
        {
            return value switch
            {
                MessageContentResourceOutputTextType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentResourceOutputTextType? ToEnum(string value)
        {
            return value switch
            {
                "output_text" => MessageContentResourceOutputTextType.OutputText,
                _ => null,
            };
        }
    }
}