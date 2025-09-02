
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. Has no effect on the conversation.
    /// </summary>
    public enum RealtimeConversationItemMessageUserStatus
    {
        /// <summary>
        /// 
        /// </summary>
        Completed,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageUserStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageUserStatus value)
        {
            return value switch
            {
                RealtimeConversationItemMessageUserStatus.Completed => "completed",
                RealtimeConversationItemMessageUserStatus.Incomplete => "incomplete",
                RealtimeConversationItemMessageUserStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageUserStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemMessageUserStatus.Completed,
                "incomplete" => RealtimeConversationItemMessageUserStatus.Incomplete,
                "in_progress" => RealtimeConversationItemMessageUserStatus.InProgress,
                _ => null,
            };
        }
    }
}