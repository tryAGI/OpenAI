
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The status of the item.<br/>
    /// Example: completed
    /// </summary>
    public enum RealtimeConversationItemStatus
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
    public static class RealtimeConversationItemStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemStatus value)
        {
            return value switch
            {
                RealtimeConversationItemStatus.Completed => "completed",
                RealtimeConversationItemStatus.InProgress => "in_progress",
                RealtimeConversationItemStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemStatus.Completed,
                "in_progress" => RealtimeConversationItemStatus.InProgress,
                "incomplete" => RealtimeConversationItemStatus.Incomplete,
                _ => null,
            };
        }
    }
}