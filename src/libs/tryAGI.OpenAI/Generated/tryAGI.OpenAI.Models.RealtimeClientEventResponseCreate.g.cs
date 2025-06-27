
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// This event instructs the server to create a Response, which means triggering <br/>
    /// model inference. When in Server VAD mode, the server will create Responses <br/>
    /// automatically.<br/>
    /// A Response will include at least one Item, and may have two, in which case <br/>
    /// the second will be a function call. These Items will be appended to the <br/>
    /// conversation history.<br/>
    /// The server will respond with a `response.created` event, events for Items <br/>
    /// and content created, and finally a `response.done` event to indicate the <br/>
    /// Response is complete.<br/>
    /// The `response.create` event includes inference configuration like <br/>
    /// `instructions`, and `temperature`. These fields will override the Session's <br/>
    /// configuration for this Response only.
    /// </summary>
    public sealed partial class RealtimeClientEventResponseCreate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Create a new Realtime response with these parameters
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::tryAGI.OpenAI.RealtimeResponseCreateParams? Response { get; set; }

        /// <summary>
        /// The event type, must be `response.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCreateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType Type { get; set; }

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
        /// <param name="response">
        /// Create a new Realtime response with these parameters
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.create`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventResponseCreate(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseCreateParams? response,
            global::tryAGI.OpenAI.RealtimeClientEventResponseCreateType type)
        {
            this.EventId = eventId;
            this.Response = response;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCreate" /> class.
        /// </summary>
        public RealtimeClientEventResponseCreate()
        {
        }
    }
}