
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The incoming transport type. Always `sip`.
    /// </summary>
    public enum WebhookLiveTransportIncomingDataType
    {
        /// <summary>
        ///
        /// </summary>
        Sip,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookLiveTransportIncomingDataTypeExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookLiveTransportIncomingDataType value)
        {
            return value switch
            {
                WebhookLiveTransportIncomingDataType.Sip => "sip",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookLiveTransportIncomingDataType? ToEnum(string value)
        {
            return value switch
            {
                "sip" => WebhookLiveTransportIncomingDataType.Sip,
                _ => null,
            };
        }
    }
}