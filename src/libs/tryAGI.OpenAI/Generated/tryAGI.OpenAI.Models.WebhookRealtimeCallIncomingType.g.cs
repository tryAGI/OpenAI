
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `realtime.call.incoming`.
    /// </summary>
    public enum WebhookRealtimeCallIncomingType
    {
        /// <summary>
        /// 
        /// </summary>
        RealtimeCallIncoming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookRealtimeCallIncomingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookRealtimeCallIncomingType value)
        {
            return value switch
            {
                WebhookRealtimeCallIncomingType.RealtimeCallIncoming => "realtime.call.incoming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookRealtimeCallIncomingType? ToEnum(string value)
        {
            return value switch
            {
                "realtime.call.incoming" => WebhookRealtimeCallIncomingType.RealtimeCallIncoming,
                _ => null,
            };
        }
    }
}