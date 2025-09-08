
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.truncate`.
    /// </summary>
    public enum RealtimeBetaClientEventConversationItemTruncateType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemTruncate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventConversationItemTruncateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventConversationItemTruncateType value)
        {
            return value switch
            {
                RealtimeBetaClientEventConversationItemTruncateType.ConversationItemTruncate => "conversation.item.truncate",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventConversationItemTruncateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.truncate" => RealtimeBetaClientEventConversationItemTruncateType.ConversationItemTruncate,
                _ => null,
            };
        }
    }
}