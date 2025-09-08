
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.truncated`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemTruncatedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncated,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemTruncatedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemTruncatedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemTruncatedType.ConversationItemTruncated => "conversation.item.truncated",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemTruncatedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncated" => RealtimeBetaServerEventConversationItemTruncatedType.ConversationItemTruncated,
                _ => null,
            };
        }
    }
}