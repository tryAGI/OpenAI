
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The role of the message sender. Always `user`.
    /// </summary>
    public enum RealtimeConversationItemMessageUserRole
    {
        /// <summary>
        /// 
        /// </summary>
        User,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageUserRoleExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageUserRole value)
        {
            return value switch
            {
                RealtimeConversationItemMessageUserRole.User => "user",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageUserRole? ToEnum(string value)
        {
            return value switch
            {
                "user" => RealtimeConversationItemMessageUserRole.User,
                _ => null,
            };
        }
    }
}