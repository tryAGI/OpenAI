
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The content type. Always `encrypted_content`.<br/>
    /// Default Value: encrypted_content
    /// </summary>
    public enum EncryptedContentResourceType
    {
        /// <summary>
        ///
        /// </summary>
        EncryptedContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class EncryptedContentResourceTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this EncryptedContentResourceType value)
        {
            return value switch
            {
                EncryptedContentResourceType.EncryptedContent => "encrypted_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static EncryptedContentResourceType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => EncryptedContentResourceType.EncryptedContent,
                _ => null,
            };
        }
    }
}