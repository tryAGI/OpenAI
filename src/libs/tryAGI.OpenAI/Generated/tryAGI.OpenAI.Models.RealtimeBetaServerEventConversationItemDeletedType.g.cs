
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.deleted`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemDeletedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemDeletedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemDeletedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemDeletedType.ConversationItemDeleted => "conversation.item.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemDeletedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.deleted" => RealtimeBetaServerEventConversationItemDeletedType.ConversationItemDeleted,
                _ => null,
            };
        }
    }
}