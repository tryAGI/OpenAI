
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.retrieved`.
    /// </summary>
    public enum RealtimeBetaServerEventConversationItemRetrievedType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieved,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaServerEventConversationItemRetrievedTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaServerEventConversationItemRetrievedType value)
        {
            return value switch
            {
                RealtimeBetaServerEventConversationItemRetrievedType.ConversationItemRetrieved => "conversation.item.retrieved",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaServerEventConversationItemRetrievedType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieved" => RealtimeBetaServerEventConversationItemRetrievedType.ConversationItemRetrieved,
                _ => null,
            };
        }
    }
}