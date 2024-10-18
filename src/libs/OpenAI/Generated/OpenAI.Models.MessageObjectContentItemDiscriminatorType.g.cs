
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum MessageObjectContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        ImageFile,
        /// <summary>
        /// 
        /// </summary>
        ImageUrl,
        /// <summary>
        /// 
        /// </summary>
        Text,
        /// <summary>
        /// 
        /// </summary>
        Refusal,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class MessageObjectContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this MessageObjectContentItemDiscriminatorType value)
        {
            return value switch
            {
                MessageObjectContentItemDiscriminatorType.ImageFile => "image_file",
                MessageObjectContentItemDiscriminatorType.ImageUrl => "image_url",
                MessageObjectContentItemDiscriminatorType.Text => "text",
                MessageObjectContentItemDiscriminatorType.Refusal => "refusal",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static MessageObjectContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "image_file" => MessageObjectContentItemDiscriminatorType.ImageFile,
                "image_url" => MessageObjectContentItemDiscriminatorType.ImageUrl,
                "text" => MessageObjectContentItemDiscriminatorType.Text,
                "refusal" => MessageObjectContentItemDiscriminatorType.Refusal,
                _ => null,
            };
        }
    }
}