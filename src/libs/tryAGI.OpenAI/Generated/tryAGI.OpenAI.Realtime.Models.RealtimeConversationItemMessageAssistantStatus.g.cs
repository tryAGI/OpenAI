
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// The status of the item. Has no effect on the conversation.
    /// </summary>
    public enum RealtimeConversationItemMessageAssistantStatus
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
    public static class RealtimeConversationItemMessageAssistantStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageAssistantStatus value)
        {
            return value switch
            {
                RealtimeConversationItemMessageAssistantStatus.Completed => "completed",
                RealtimeConversationItemMessageAssistantStatus.InProgress => "in_progress",
                RealtimeConversationItemMessageAssistantStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageAssistantStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemMessageAssistantStatus.Completed,
                "in_progress" => RealtimeConversationItemMessageAssistantStatus.InProgress,
                "incomplete" => RealtimeConversationItemMessageAssistantStatus.Incomplete,
                _ => null,
            };
        }
    }
}