
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.create`.
    /// </summary>
    public enum RealtimeBetaClientEventConversationItemCreateType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemCreate,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventConversationItemCreateTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventConversationItemCreateType value)
        {
            return value switch
            {
                RealtimeBetaClientEventConversationItemCreateType.ConversationItemCreate => "conversation.item.create",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventConversationItemCreateType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.create" => RealtimeBetaClientEventConversationItemCreateType.ConversationItemCreate,
                _ => null,
            };
        }
    }
}