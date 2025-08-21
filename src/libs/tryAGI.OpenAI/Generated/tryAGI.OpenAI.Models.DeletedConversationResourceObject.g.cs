
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Default Value: conversation.deleted
    /// </summary>
    public enum DeletedConversationResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        ConversationDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedConversationResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedConversationResourceObject value)
        {
            return value switch
            {
                DeletedConversationResourceObject.ConversationDeleted => "conversation.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedConversationResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation.deleted" => DeletedConversationResourceObject.ConversationDeleted,
                _ => null,
            };
        }
    }
}