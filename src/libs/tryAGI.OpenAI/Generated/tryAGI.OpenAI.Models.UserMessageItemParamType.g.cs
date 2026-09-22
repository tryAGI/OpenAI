
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The item type. Always `message`.<br/>
    /// Default Value: message
    /// </summary>
    public enum UserMessageItemParamType
    {
        /// <summary>
        ///
        /// </summary>
        Message,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageItemParamTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageItemParamType value)
        {
            return value switch
            {
                UserMessageItemParamType.Message => "message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageItemParamType? ToEnum(string value)
        {
            return value switch
            {
                "message" => UserMessageItemParamType.Message,
                _ => null,
            };
        }
    }
}