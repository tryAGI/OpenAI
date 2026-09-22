
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The object type, which is always webhook_endpoint.deleted.<br/>
    /// Default Value: webhook_endpoint.deleted
    /// </summary>
    public enum DeletedWebhookEndpointResourceObject
    {
        /// <summary>
        ///
        /// </summary>
        WebhookEndpointDeleted,
    }

    /// <summary>
    /// Enum extensions to do fast conversions without the reflection.
    /// </summary>
    public static class DeletedWebhookEndpointResourceObjectExtensions
    {
        /// <summary>
        /// Converts an enum to a string.
        /// </summary>
        public static string ToValueString(this DeletedWebhookEndpointResourceObject value)
        {
            return value switch
            {
                DeletedWebhookEndpointResourceObject.WebhookEndpointDeleted => "webhook_endpoint.deleted",
                _ => throw new global::System.ArgumentOutOfRangeException(nameof(value), value, null),
            };
        }
        /// <summary>
        /// Converts an string to a enum.
        /// </summary>
        public static DeletedWebhookEndpointResourceObject? ToEnum(string value)
        {
            return value switch
            {
                "webhook_endpoint.deleted" => DeletedWebhookEndpointResourceObject.WebhookEndpointDeleted,
                _ => null,
            };
        }
    }
}