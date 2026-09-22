
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always webhook_endpoint.<br/>
    /// Default Value: webhook_endpoint
    /// </summary>
    public enum WebhookEndpointBodyObject
    {
        /// <summary>
        ///
        /// </summary>
        WebhookEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEndpointBodyObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEndpointBodyObject value)
        {
            return value switch
            {
                WebhookEndpointBodyObject.WebhookEndpoint => "webhook_endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEndpointBodyObject? ToEnum(string value)
        {
            return value switch
            {
                "webhook_endpoint" => WebhookEndpointBodyObject.WebhookEndpoint,
                _ => null,
            };
        }
    }
}