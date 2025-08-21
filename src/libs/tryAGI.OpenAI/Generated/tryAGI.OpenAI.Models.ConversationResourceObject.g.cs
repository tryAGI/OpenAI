
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always `conversation`.<br/>
    /// Default Value: conversation
    /// </summary>
    public enum ConversationResourceObject
    {
        /// <summary>
        /// 
        /// </summary>
        Conversation,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationResourceObject value)
        {
            return value switch
            {
                ConversationResourceObject.Conversation => "conversation",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "conversation" => ConversationResourceObject.Conversation,
                _ => null,
            };
        }
    }
}