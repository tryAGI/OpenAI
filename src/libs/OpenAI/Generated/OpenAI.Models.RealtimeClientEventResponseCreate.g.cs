
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// This event instructs the server to create a Response, which means triggering model inference. When in Server VAD mode, the server will create Responses automatically.<br/>
    /// A Response will include at least one Item, and may have two, in which case the second will be a function call. These Items will be appended to the conversation history.<br/>
    /// The server will respond with a `response.created` event, events for Items and content created, and finally a `response.done` event to indicate the Response is complete.<br/>
    /// The `response.create` event includes inference configuration like `instructions`, and `temperature`. These fields will override the Session's configuration for this Response only.
    /// </summary>
    public sealed partial class RealtimeClientEventResponseCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be `response.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RealtimeResponse Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCreate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.create`.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeClientEventResponseCreate(
            string type,
            global::OpenAI.RealtimeResponse response,
            string? eventId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Response = response ?? throw new global::System.ArgumentNullException(nameof(response));
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCreate" /> class.
        /// </summary>
        public RealtimeClientEventResponseCreate()
        {
        }
    }
}