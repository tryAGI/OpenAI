
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: chatkit.user_message
    /// </summary>
    public enum UserMessageItemType
    {
        /// <summary>
        /// 
        /// </summary>
        ChatkitUserMessage,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class UserMessageItemTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this UserMessageItemType value)
        {
            return value switch
            {
                UserMessageItemType.ChatkitUserMessage => "chatkit.user_message",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static UserMessageItemType? ToEnum(string value)
        {
            return value switch
            {
                "chatkit.user_message" => UserMessageItemType.ChatkitUserMessage,
                _ => null,
            };
        }
    }
}