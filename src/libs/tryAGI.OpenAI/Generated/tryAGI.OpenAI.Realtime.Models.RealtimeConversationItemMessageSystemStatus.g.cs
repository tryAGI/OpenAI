
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The status of the item. Has no effect on the conversation.
    /// </summary>
    public enum RealtimeConversationItemMessageSystemStatus
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
    public static class RealtimeConversationItemMessageSystemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageSystemStatus value)
        {
            return value switch
            {
                RealtimeConversationItemMessageSystemStatus.Completed => "completed",
                RealtimeConversationItemMessageSystemStatus.InProgress => "in_progress",
                RealtimeConversationItemMessageSystemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageSystemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemMessageSystemStatus.Completed,
                "in_progress" => RealtimeConversationItemMessageSystemStatus.InProgress,
                "incomplete" => RealtimeConversationItemMessageSystemStatus.Incomplete,
                _ => null,
            };
        }
    }
}