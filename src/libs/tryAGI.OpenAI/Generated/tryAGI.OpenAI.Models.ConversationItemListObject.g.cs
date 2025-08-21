
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of object returned, must be `list`.
    /// </summary>
    public enum ConversationItemListObject
    {
        /// <summary>
        /// 
        /// </summary>
        List,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ConversationItemListObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ConversationItemListObject value)
        {
            return value switch
            {
                ConversationItemListObject.List => "list",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ConversationItemListObject? ToEnum(string value)
        {
            return value switch
            {
                "list" => ConversationItemListObject.List,
                _ => null,
            };
        }
    }
}