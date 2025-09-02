
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
        Incomplete,
        /// <summary>
        /// 
        /// </summary>
        InProgress,
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
                RealtimeConversationItemFunctionCallStatus.Incomplete => "incomplete",
                RealtimeConversationItemFunctionCallStatus.InProgress => "in_progress",
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
                "incomplete" => RealtimeConversationItemFunctionCallStatus.Incomplete,
                "in_progress" => RealtimeConversationItemFunctionCallStatus.InProgress,
                _ => null,
            };
        }
    }
}