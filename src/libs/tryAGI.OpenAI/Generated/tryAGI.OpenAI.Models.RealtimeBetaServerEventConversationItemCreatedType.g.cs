
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.created`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemCreatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemCreatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemCreatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemCreatedType.ConversationItemCreated => "conversation.item.created",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemCreatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.created" => RealtimeBetaServerEventConversationItemCreatedType.ConversationItemCreated,
                _ => null,
            };
        }
    }
}