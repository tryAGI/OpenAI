
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to update the session’s configuration.<br/>
    /// The client may send this event at any time to update any field<br/>
    /// except for `voice` and `model`. `voice` can be updated only if there have been no other<br/>
    /// audio outputs yet. <br/>
    /// When the server receives a `session.update`, it will respond<br/>
    /// with a `session.updated` event showing the full, effective configuration.<br/>
    /// Only the fields that are present in the `session.update` are updated. To clear a field like<br/>
    /// `instructions`, pass an empty string. To clear a field like `tools`, pass an empty array.<br/>
    /// To clear a field like `turn_detection`, pass `null`.
    /// </summary>
    public sealed partial class RealtimeClientEventSessionUpdate
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event. This is an arbitrary string that a client may assign. It will be passed back if there is an error with the event, but the corresponding `session.updated` event will not include it.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Update the Realtime session. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA> Session { get; set; }

        /// <summary>
        /// The event type, must be `session.update`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeClientEventSessionUpdateTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event. This is an arbitrary string that a client may assign. It will be passed back if there is an error with the event, but the corresponding `session.updated` event will not include it.
        /// </param>
        /// <param name="session">
        /// Update the Realtime session. Choose either a realtime<br/>
        /// session or a transcription session.
        /// </param>
        /// <param name="type">
        /// The event type, must be `session.update`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeClientEventSessionUpdate(
            global::tryAGI.OpenAI.AnyOf<global::tryAGI.OpenAI.RealtimeSessionCreateRequestGA, global::tryAGI.OpenAI.RealtimeTranscriptionSessionCreateRequestGA> session,
            string? eventId,
            global::tryAGI.OpenAI.RealtimeClientEventSessionUpdateType type)
        {
            this.Session = session;
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeClientEventSessionUpdate" /> class.
        /// </summary>
        public RealtimeClientEventSessionUpdate()
        {
        }
    }
}