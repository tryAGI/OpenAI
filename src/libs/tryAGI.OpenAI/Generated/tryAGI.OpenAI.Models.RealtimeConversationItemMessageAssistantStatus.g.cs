
#nullable enable

namespace tryAGI.OpenAI
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
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
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
                RealtimeConversationItemMessageAssistantStatus.Incomplete => "incomplete",
                RealtimeConversationItemMessageAssistantStatus.InProgress => "in_progress",
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
                "incomplete" => RealtimeConversationItemMessageAssistantStatus.Incomplete,
                "in_progress" => RealtimeConversationItemMessageAssistantStatus.InProgress,
                _ => null,
            };
        }
    }
}