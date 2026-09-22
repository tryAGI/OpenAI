
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public enum MessageContentResourceDiscriminatorType
    {
        /// <summary>
        ///
        /// </summary>
        InputImage,
        /// <summary>
        ///
        /// </summary>
        InputText,
        /// <summary>
        ///
        /// </summary>
        OutputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageContentResourceDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageContentResourceDiscriminatorType value)
        {
            return value switch
            {
                MessageContentResourceDiscriminatorType.InputImage => "input_image",
                MessageContentResourceDiscriminatorType.InputText => "input_text",
                MessageContentResourceDiscriminatorType.OutputText => "output_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageContentResourceDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_image" => MessageContentResourceDiscriminatorType.InputImage,
                "input_text" => MessageContentResourceDiscriminatorType.InputText,
                "output_text" => MessageContentResourceDiscriminatorType.OutputText,
                _ => null,
            };
        }
    }
}