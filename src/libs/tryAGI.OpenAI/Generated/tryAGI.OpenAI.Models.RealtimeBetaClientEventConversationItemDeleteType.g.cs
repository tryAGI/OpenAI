
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.delete`.
    /// </summary>
    public enum RealtimeBetaClientEventConversationItemDeleteType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemDelete,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventConversationItemDeleteTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventConversationItemDeleteType value)
        {
            return value switch
            {
                RealtimeBetaClientEventConversationItemDeleteType.ConversationItemDelete => "conversation.item.delete",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventConversationItemDeleteType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.delete" => RealtimeBetaClientEventConversationItemDeleteType.ConversationItemDelete,
                _ => null,
            };
        }
    }
}