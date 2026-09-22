
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `text`.<br/>
    /// Default Value: text
    /// </summary>
    public enum TextFormatResourceTextType
    {
        /// <summary>
        ///
        /// </summary>
        Text,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class TextFormatResourceTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this TextFormatResourceTextType value)
        {
            return value switch
            {
                TextFormatResourceTextType.Text => "text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static TextFormatResourceTextType? ToEnum(string value)
        {
            return value switch
            {
                "text" => TextFormatResourceTextType.Text,
                _ => null,
            };
        }
    }
}