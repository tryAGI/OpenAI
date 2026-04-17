
#nullable enable

namespace tryAGI.OpenAI.Realtime
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
        InProgress,
        /// <summary>
        /// 
        /// </summary>
        Incomplete,
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
                RealtimeConversationItemMessageUserStatus.InProgress => "in_progress",
                RealtimeConversationItemMessageUserStatus.Incomplete => "incomplete",
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
                "in_progress" => RealtimeConversationItemMessageUserStatus.InProgress,
                "incomplete" => RealtimeConversationItemMessageUserStatus.Incomplete,
                _ => null,
            };
        }
    }
}