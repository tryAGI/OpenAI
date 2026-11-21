
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class WebhookEndpointTestResultResource
    {
        /// <summary>
        /// The object type, which is always webhook_endpoint.test.<br/>
        /// Default Value: webhook_endpoint.test
        /// </summary>
        /// <default>"webhook_endpoint.test"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "webhook_endpoint.test";

        /// <summary>
        /// The ID of the webhook endpoint that received the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("webhook_endpoint_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string WebhookEndpointId { get; set; }

        /// <summary>
        /// The event type sent in the test.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventType { get; set; }

        /// <summary>
        /// The HTTP status code returned by the endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status_code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int StatusCode { get; set; }

        /// <summary>
        /// Whether the test request completed. Always true for returned results; use status_code to determine the endpoint response.<br/>
        /// Default Value: true
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("success")]
        public bool Success { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointTestResultResource" /> class.
        /// </summary>
        /// <param name="webhookEndpointId">
        /// The ID of the webhook endpoint that received the test.
        /// </param>
        /// <param name="eventType">
        /// The event type sent in the test.
        /// </param>
        /// <param name="statusCode">
        /// The HTTP status code returned by the endpoint.
        /// </param>
        /// <param name="success">
        /// Whether the test request completed. Always true for returned results; use status_code to determine the endpoint response.<br/>
        /// Default Value: true
        /// </param>
        /// <param name="object">
        /// The object type, which is always webhook_endpoint.test.<br/>
        /// Default Value: webhook_endpoint.test
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookEndpointTestResultResource(
            string webhookEndpointId,
            string eventType,
            int statusCode,
            bool success,
            string @object = "webhook_endpoint.test")
        {
            this.Object = @object;
            this.WebhookEndpointId = webhookEndpointId ?? throw new global::System.ArgumentNullException(nameof(webhookEndpointId));
            this.EventType = eventType ?? throw new global::System.ArgumentNullException(nameof(eventType));
            this.StatusCode = statusCode;
            this.Success = success;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookEndpointTestResultResource" /> class.
        /// </summary>
        public WebhookEndpointTestResultResource()
        {
        }

    }
}