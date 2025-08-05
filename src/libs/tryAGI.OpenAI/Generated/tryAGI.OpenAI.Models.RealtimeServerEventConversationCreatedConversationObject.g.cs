
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, must be `realtime.conversation`.
    /// </summary>
    public enum RealtimeServerEventConversationCreatedConversationObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeServerEventConversationCreatedConversationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeServerEventConversationCreatedConversationObject value)
        {
            return value switch
            {
                RealtimeServerEventConversationCreatedConversationObject.RealtimeConversation => "realtime.conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeServerEventConversationCreatedConversationObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.conversation" => RealtimeServerEventConversationCreatedConversationObject.RealtimeConversation,
                _ => null,
            };
        }
    }
}