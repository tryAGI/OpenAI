
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Type discriminator that is always `input_text`.<br/>
    /// Default Value: input_text
    /// </summary>
    public enum UserMessageInputTextType
    {
        /// <summary>
        /// 
        /// </summary>
        InputText,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageInputTextTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageInputTextType value)
        {
            return value switch
            {
                UserMessageInputTextType.InputText => "input_text",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageInputTextType? ToEnum(string value)
        {
            return value switch
            {
                "input_text" => UserMessageInputTextType.InputText,
                _ => null,
            };
        }
    }
}