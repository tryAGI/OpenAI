
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always webhook_endpoint.<br/>
    /// Default Value: webhook_endpoint
    /// </summary>
    public enum WebhookEndpointWithSecretResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        WebhookEndpoint,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class WebhookEndpointWithSecretResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this WebhookEndpointWithSecretResourceObject value)
        {
            return value switch
            {
                WebhookEndpointWithSecretResourceObject.WebhookEndpoint => "webhook_endpoint",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static WebhookEndpointWithSecretResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "webhook_endpoint" => WebhookEndpointWithSecretResourceObject.WebhookEndpoint,
                _ => null,
            };
        }
    }
}