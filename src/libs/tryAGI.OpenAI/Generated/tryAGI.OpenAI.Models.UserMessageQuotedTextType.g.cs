
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `quoted_text`.<br/>
    /// Default Value: quoted_text
    /// </summary>
    public enum UserMessageQuotedTextType
    {
        /// <summary>
        /// 
        /// </summary>
        QuotedText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageQuotedTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageQuotedTextType value)
        {
            return value switch
            {
                UserMessageQuotedTextType.QuotedText => "quoted_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageQuotedTextType? ToEnum(string value)
        {
            return value switch
            {
                "quoted_text" => UserMessageQuotedTextType.QuotedText,
                _ => null,
            };
        }
    }
}