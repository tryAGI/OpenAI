
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class DeletedWebhookEndpointResource
    {
        /// <summary>
        /// The ID of the deleted webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always webhook_endpoint.deleted.<br/>
        /// Default Value: webhook_endpoint.deleted
        /// </summary>
        /// <default>global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject.WebhookEndpointDeleted</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.DeletedWebhookEndpointResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject Object { get; set; } = global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject.WebhookEndpointDeleted;

        /// <summary>
        /// Whether the endpoint was deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedWebhookEndpointResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the deleted webhook endpoint.
        /// </param>
        /// <param name="deleted">
        /// Whether the endpoint was deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always webhook_endpoint.deleted.<br/>
        /// Default Value: webhook_endpoint.deleted
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public DeletedWebhookEndpointResource(
            string id,
            bool deleted,
            global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject @object = global::tryAGI.OpenAI.DeletedWebhookEndpointResourceObject.WebhookEndpointDeleted)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DeletedWebhookEndpointResource" /> class.
        /// </summary>
        public DeletedWebhookEndpointResource()
        {
        }

    }
}