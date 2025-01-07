
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, must be "realtime.conversation".<br/>
    /// Example: realtime.conversation
    /// </summary>
    public enum RealtimeConversationObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeConversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationObject value)
        {
            return value switch
            {
                RealtimeConversationObject.RealtimeConversation => "realtime.conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.conversation" => RealtimeConversationObject.RealtimeConversation,
                _ => null,
            };
        }
    }
}