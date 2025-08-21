
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public enum ListConversationItemsOrder
    {
        /// <summary>
        /// Return the input items in ascending order.
        /// </summary>
        Asc,
        /// <summary>
        /// Return the input items in descending order.
        /// </summary>
        Desc,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class ListConversationItemsOrderExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this ListConversationItemsOrder value)
        {
            return value switch
            {
                ListConversationItemsOrder.Asc => "asc",
                ListConversationItemsOrder.Desc => "desc",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static ListConversationItemsOrder? ToEnum(string value)
        {
            return value switch
            {
                "asc" => ListConversationItemsOrder.Asc,
                "desc" => ListConversationItemsOrder.Desc,
                _ => null,
            };
        }
    }
}