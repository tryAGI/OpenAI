
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A streaming Responses API event from a backend delegated to by the Live session. Use the outer delegation_id to associate the nested stream with its Live delegation.<br/>
    /// Example: {"type":"response.event","event_id":"evt_response_002","delegation_id":"del_responses123","event":{"type":"response.output_text.delta","item_id":"msg_abc123","output_index":0,"content_index":0,"delta":"An outdoor table is available at 7 PM.","sequence_number":3,"logprobs":[]}}
    /// </summary>
    public sealed partial class LiveResponseEvent
    {
        /// <summary>
        /// The unique ID of the Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event_id of the client command associated with this server event, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// The event type, always `response.event`.<br/>
        /// Default Value: response.event
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveResponseEventType.ResponseEvent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveResponseEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveResponseEventType Type { get; set; } = global::tryAGI.OpenAI.LiveResponseEventType.ResponseEvent;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_id")]
        public string? DelegationId { get; set; }

        /// <summary>
        /// The nested Responses streaming event. Dispatch on its type field. Response lifecycle snapshots omit input and clear instructions, tools, and output to keep messages small; consume granular output events for the generated content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required object Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the Live server event.
        /// </param>
        /// <param name="event">
        /// The nested Responses streaming event. Dispatch on its type field. Response lifecycle snapshots omit input and clear instructions, tools, and output to keep messages small; consume granular output events for the generated content.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command associated with this server event, when supplied.
        /// </param>
        /// <param name="delegationId"></param>
        /// <param name="type">
        /// The event type, always `response.event`.<br/>
        /// Default Value: response.event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveResponseEvent(
            string eventId,
            object @event,
            string? clientEventId,
            string? delegationId,
            global::tryAGI.OpenAI.LiveResponseEventType type = global::tryAGI.OpenAI.LiveResponseEventType.ResponseEvent)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ClientEventId = clientEventId;
            this.Type = type;
            this.DelegationId = delegationId;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveResponseEvent" /> class.
        /// </summary>
        public LiveResponseEvent()
        {
        }

    }
}