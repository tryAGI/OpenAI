
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifier for the API object being returned - always `realtime.item`. Optional when creating a new item.
    /// </summary>
    public enum RealtimeConversationItemMessageAssistantObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageAssistantObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageAssistantObject value)
        {
            return value switch
            {
                RealtimeConversationItemMessageAssistantObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageAssistantObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemMessageAssistantObject.RealtimeItem,
                _ => null,
            };
        }
    }
}