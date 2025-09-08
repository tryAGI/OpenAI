
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The event type, must be `conversation.item.retrieve`.
    /// </summary>
    public enum RealtimeBetaClientEventConversationItemRetrieveType
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationItemRetrieve,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeBetaClientEventConversationItemRetrieveTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeBetaClientEventConversationItemRetrieveType value)
        {
            return value switch
            {
                RealtimeBetaClientEventConversationItemRetrieveType.ConversationItemRetrieve => "conversation.item.retrieve",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeBetaClientEventConversationItemRetrieveType? ToEnum(string value)
        {
            return value switch
            {
                "conversation.item.retrieve" => RealtimeBetaClientEventConversationItemRetrieveType.ConversationItemRetrieve,
                _ => null,
            };
        }
    }
}