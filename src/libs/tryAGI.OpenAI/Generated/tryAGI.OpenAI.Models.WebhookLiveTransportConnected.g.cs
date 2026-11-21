
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Sent when a direct Live WebRTC session is created or an Instant Connect session activates. Use its session ID to attach a sideband observer.
    /// </summary>
    public sealed partial class WebhookLiveTransportConnected
    {
        /// <summary>
        /// The webhook event ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"event"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "event";

        /// <summary>
        /// Unix time in seconds when the event was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        ///
        /// </summary>
        /// <default>"live.transport.connected"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "live.transport.connected";

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.WebhookLiveTransportConnectedData Data { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportConnected" /> class.
        /// </summary>
        /// <param name="id">
        /// The webhook event ID.
        /// </param>
        /// <param name="createdAt">
        /// Unix time in seconds when the event was created.
        /// </param>
        /// <param name="data"></param>
        /// <param name="object"></param>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public WebhookLiveTransportConnected(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.WebhookLiveTransportConnectedData data,
            string @object = "event",
            string type = "live.transport.connected")
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.Type = type;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="WebhookLiveTransportConnected" /> class.
        /// </summary>
        public WebhookLiveTransportConnected()
        {
        }

    }
}