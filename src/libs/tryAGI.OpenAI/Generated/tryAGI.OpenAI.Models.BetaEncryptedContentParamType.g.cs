
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the input item. Always `encrypted_content`.<br/>
    /// Default Value: encrypted_content
    /// </summary>
    public enum BetaEncryptedContentParamType
    {
        /// <summary>
        ///
        /// </summary>
        EncryptedContent,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class BetaEncryptedContentParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this BetaEncryptedContentParamType value)
        {
            return value switch
            {
                BetaEncryptedContentParamType.EncryptedContent => "encrypted_content",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static BetaEncryptedContentParamType? ToEnum(string value)
        {
            return value switch
            {
                "encrypted_content" => BetaEncryptedContentParamType.EncryptedContent,
                _ => null,
            };
        }
    }
}