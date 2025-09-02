
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifier for the API object being returned - always `realtime.item`.
    /// </summary>
    public enum RealtimeConversationItemMessageUserObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageUserObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageUserObject value)
        {
            return value switch
            {
                RealtimeConversationItemMessageUserObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageUserObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemMessageUserObject.RealtimeItem,
                _ => null,
            };
        }
    }
}