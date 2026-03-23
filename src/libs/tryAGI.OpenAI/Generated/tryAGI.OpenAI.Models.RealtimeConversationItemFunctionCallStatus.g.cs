
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The status of the item. Has no effect on the conversation.
    /// </summary>
    public enum RealtimeConversationItemFunctionCallStatus
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
    public static class RealtimeConversationItemFunctionCallStatusExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemFunctionCallStatus value)
        {
            return value switch
            {
                RealtimeConversationItemFunctionCallStatus.Completed => "completed",
                RealtimeConversationItemFunctionCallStatus.InProgress => "in_progress",
                RealtimeConversationItemFunctionCallStatus.Incomplete => "incomplete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemFunctionCallStatus? ToEnum(string value)
        {
            return value switch
            {
                "completed" => RealtimeConversationItemFunctionCallStatus.Completed,
                "in_progress" => RealtimeConversationItemFunctionCallStatus.InProgress,
                "incomplete" => RealtimeConversationItemFunctionCallStatus.Incomplete,
                _ => null,
            };
        }
    }
}