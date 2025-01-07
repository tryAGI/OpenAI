
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, must be "realtime.item".<br/>
    /// Example: realtime.item
    /// </summary>
    public enum RealtimeConversationItemObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemObject value)
        {
            return value switch
            {
                RealtimeConversationItemObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemObject.RealtimeItem,
                _ => null,
            };
        }
    }
}