
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item (`completed`, `incomplete`, `in_progress`). These have no effect <br/>
    /// on the conversation, but are accepted for consistency with the <br/>
    /// `conversation.item.created` event.
    /// </summary>
    public enum RealtimeConversationItemWithReferenceStatus
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
    public static class RealtimeConversationItemWithReferenceStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemWithReferenceStatus value)
        {
            return value switch
            {
                RealtimeConversationItemWithReferenceStatus.Completed => "completed",
                RealtimeConversationItemWithReferenceStatus.InProgress => "in_progress",
                RealtimeConversationItemWithReferenceStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemWithReferenceStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemWithReferenceStatus.Completed,
                "in_progress" => RealtimeConversationItemWithReferenceStatus.InProgress,
                "incomplete" => RealtimeConversationItemWithReferenceStatus.Incomplete,
                _ => null,
            };
        }
    }
}