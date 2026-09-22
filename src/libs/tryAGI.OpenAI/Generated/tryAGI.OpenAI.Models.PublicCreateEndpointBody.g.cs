
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class PublicCreateEndpointBody
    {
        /// <summary>
        /// A human-readable name for the webhook endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The HTTPS URL that receives webhook deliveries.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("url")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Url { get; set; }

        /// <summary>
        /// The event types that trigger deliveries to this endpoint.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_types")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum> EventTypes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateEndpointBody" /> class.
        /// </summary>
        /// <param name="name">
        /// A human-readable name for the webhook endpoint.
        /// </param>
        /// <param name="url">
        /// The HTTPS URL that receives webhook deliveries.
        /// </param>
        /// <param name="eventTypes">
        /// The event types that trigger deliveries to this endpoint.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicCreateEndpointBody(
            string name,
            string url,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectEventTypeEnum> eventTypes)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Url = url ?? throw new global::System.ArgumentNullException(nameof(url));
            this.EventTypes = eventTypes ?? throw new global::System.ArgumentNullException(nameof(eventTypes));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateEndpointBody" /> class.
        /// </summary>
        public PublicCreateEndpointBody()
        {
        }

    }
}