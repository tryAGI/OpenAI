
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to cancel an in-progress response. The server will respond <br/>
    /// with a `response.done` event with a status of `response.status=cancelled`. If <br/>
    /// there is no response to cancel, the server will respond with an error. It's safe<br/>
    /// to call `response.cancel` even if no response is in progress, an error will be<br/>
    /// returned the session will remain unaffected.
    /// </summary>
    public sealed partial class RealtimeClientEventResponseCancel
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// A specific response ID to cancel - if not provided, will cancel an <br/>
        /// in-progress response in the default conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The event type, must be `response.cancel`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventResponseCancelTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCancel" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.
        /// </param>
        /// <param name="responseId">
        /// A specific response ID to cancel - if not provided, will cancel an <br/>
        /// in-progress response in the default conversation.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.cancel`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventResponseCancel(
            string? eventId,
            string? responseId,
            global::tryAGI.OpenAI.RealtimeClientEventResponseCancelType type)
        {
            this.EventId = eventId;
            this.ResponseId = responseId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventResponseCancel" /> class.
        /// </summary>
        public RealtimeClientEventResponseCancel()
        {
        }
    }
}