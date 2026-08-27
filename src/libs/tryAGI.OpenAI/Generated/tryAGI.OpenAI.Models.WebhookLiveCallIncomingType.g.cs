
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The type of the event. Always `live.call.incoming`.
    /// </summary>
    public enum WebhookLiveCallIncomingType
    {
        /// <summary>
        ///
        /// </summary>
        LiveCallIncoming,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveCallIncomingTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveCallIncomingType value)
        {
            return value switch
            {
                WebhookLiveCallIncomingType.LiveCallIncoming => "live.call.incoming",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveCallIncomingType? ToEnum(string value)
        {
            return value switch
            {
                "live.call.incoming" => WebhookLiveCallIncomingType.LiveCallIncoming,
                _ => null,
            };
        }
    }
}