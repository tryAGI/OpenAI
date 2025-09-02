
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. Has no effect on the conversation.
    /// </summary>
    public enum RealtimeConversationItemFunctionCallOutputStatus
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
    public static class RealtimeConversationItemFunctionCallOutputStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemFunctionCallOutputStatus value)
        {
            return value switch
            {
                RealtimeConversationItemFunctionCallOutputStatus.Completed => "completed",
                RealtimeConversationItemFunctionCallOutputStatus.Incomplete => "incomplete",
                RealtimeConversationItemFunctionCallOutputStatus.InProgress => "in_progress",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemFunctionCallOutputStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemFunctionCallOutputStatus.Completed,
                "incomplete" => RealtimeConversationItemFunctionCallOutputStatus.Incomplete,
                "in_progress" => RealtimeConversationItemFunctionCallOutputStatus.InProgress,
                _ => null,
            };
        }
    }
}