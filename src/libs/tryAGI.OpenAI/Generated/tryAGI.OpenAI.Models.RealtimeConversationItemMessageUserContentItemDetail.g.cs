
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The detail level of the image (for `input_image`). `auto` will default to `high`.<br/>
    /// Default Value: auto
    /// </summary>
    public enum RealtimeConversationItemMessageUserContentItemDetail
    {
        /// <summary>
        /// 
        /// </summary>
        Auto,
        /// <summary>
        /// 
        /// </summary>
        High,
        /// <summary>
        /// 
        /// </summary>
        Low,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class RealtimeConversationItemMessageUserContentItemDetailExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this RealtimeConversationItemMessageUserContentItemDetail value)
        {
            return value switch
            {
                RealtimeConversationItemMessageUserContentItemDetail.Auto => "auto",
                RealtimeConversationItemMessageUserContentItemDetail.High => "high",
                RealtimeConversationItemMessageUserContentItemDetail.Low => "low",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static RealtimeConversationItemMessageUserContentItemDetail? ToEnum(string value)
        {
            return value switch
            {
                "auto" => RealtimeConversationItemMessageUserContentItemDetail.Auto,
                "high" => RealtimeConversationItemMessageUserContentItemDetail.High,
                "low" => RealtimeConversationItemMessageUserContentItemDetail.Low,
                _ => null,
            };
        }
    }
}