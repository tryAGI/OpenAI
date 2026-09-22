
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the object. Always `input_image`.<br/>
    /// Default Value: input_image
    /// </summary>
    public enum MessageContentResourceInputImageType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentResourceInputImageTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentResourceInputImageType value)
        {
            return value switch
            {
                MessageContentResourceInputImageType.InputImage => "input_image",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentResourceInputImageType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => MessageContentResourceInputImageType.InputImage,
                _ => null,
            };
        }
    }
}