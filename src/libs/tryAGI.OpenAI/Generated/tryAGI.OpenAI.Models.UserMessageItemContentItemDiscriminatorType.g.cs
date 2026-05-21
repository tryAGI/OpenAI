
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum UserMessageItemContentItemDiscriminatorType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
        /// <summary>
        /// 
        /// </summary>
        QuotedText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageItemContentItemDiscriminatorTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageItemContentItemDiscriminatorType value)
        {
            return value switch
            {
                UserMessageItemContentItemDiscriminatorType.InputText => "input_text",
                UserMessageItemContentItemDiscriminatorType.QuotedText => "quoted_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageItemContentItemDiscriminatorType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => UserMessageItemContentItemDiscriminatorType.InputText,
                "quoted_text" => UserMessageItemContentItemDiscriminatorType.QuotedText,
                _ => null,
            };
        }
    }
}