
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicUpdateEndpointBody
    {
        /// <summary>
        /// A new human-readable name for the webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// A new HTTPS URL that receives webhook deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        public string? Url { get; set; }

        /// <summary>
        /// The complete set of event types that should trigger deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUpdateEndpointBody" /> class.
        /// </summary>
        /// <param name="name">
        /// A new human-readable name for the webhook endpoint.
        /// </param>
        /// <param name="url">
        /// A new HTTPS URL that receives webhook deliveries.
        /// </param>
        /// <param name="eventTypes">
        /// The complete set of event types that should trigger deliveries.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicUpdateEndpointBody(
            string? name,
            string? url,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum>? eventTypes)
        {
            this.Name = name;
            this.Url = url;
            this.EventTypes = eventTypes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUpdateEndpointBody" /> class.
        /// </summary>
        public PublicUpdateEndpointBody()
        {
        }

    }
}