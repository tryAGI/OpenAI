
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The event type, must be "conversation.created".<br/>
    /// Example: conversation.created
    /// </summary>
    public enum RealtimeConversationCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationCreatedType value)
        {
            return value switch
            {
                RealtimeConversationCreatedType.ConversationCreated => "conversation.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.created" => RealtimeConversationCreatedType.ConversationCreated,
                _ => null,
            };
        }
    }
}