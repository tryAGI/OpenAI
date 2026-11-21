
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when an incoming API SIP session is available for Live acceptance. The<br/>
    /// same pending session can also emit `realtime.call.incoming`; the first<br/>
    /// successful Realtime or Live accept endpoint selects the runtime surface.
    /// </summary>
    public sealed partial class WebhookLiveTransportIncoming
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Event data payload.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebhookLiveTransportIncomingData Data { get; set; }

        /// <summary>
        /// The object of the event. Always `event`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string? Object { get; set; }

        /// <summary>
        /// The type of the event. Always `live.transport.incoming`.
        /// </summary>
        /// <default>"live.transport.incoming"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "live.transport.incoming";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportIncoming" /> class.
        /// </summary>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the event was created.
        /// </param>
        /// <param name="id">
        /// The unique ID of the event.
        /// </param>
        /// <param name="data">
        /// Event data payload.
        /// </param>
        /// <param name="object">
        /// The object of the event. Always `event`.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `live.transport.incoming`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveTransportIncoming(
            int createdAt,
            string id,
            global::tryAGI.OpenAI.WebhookLiveTransportIncomingData data,
            string? @object,
            string type = "live.transport.incoming")
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Object = @object;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportIncoming" /> class.
        /// </summary>
        public WebhookLiveTransportIncoming()
        {
        }

    }
}