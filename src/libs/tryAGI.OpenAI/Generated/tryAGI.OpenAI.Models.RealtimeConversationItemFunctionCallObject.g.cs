
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Identifier for the API object being returned - always `realtime.item`.
    /// </summary>
    public enum RealtimeConversationItemFunctionCallObject
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeItem,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemFunctionCallObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemFunctionCallObject value)
        {
            return value switch
            {
                RealtimeConversationItemFunctionCallObject.RealtimeItem => "realtime.item",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemFunctionCallObject? ToEnum(string value)
        {
            return value switch
            {
                "realtime.item" => RealtimeConversationItemFunctionCallObject.RealtimeItem,
                _ => null,
            };
        }
    }
}