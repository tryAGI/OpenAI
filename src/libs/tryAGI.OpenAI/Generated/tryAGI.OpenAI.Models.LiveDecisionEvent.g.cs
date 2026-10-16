
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A Decision API event for a Live delegation or transcript trigger. For a trigger, source_event_id identifies the transcript delta that caused this evaluation.<br/>
    /// Example: {"type":"decision.event","event_id":"evt_decision_1","delegation_id":"del_abc123","trigger_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source_event_type":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","source_event_id":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event":{"type":"decision.completed","decision":{"model":"gpt-6-luna","answers":[{"type":"predicate","name":"damaged","probability":0.95}],"usage":{"input_tokens":42,"input_tokens_details":{"cached_tokens":0,"cache_write_tokens":0},"output_tokens":0,"output_tokens_details":{"reasoning_tokens":0},"total_tokens":42}}}}
    /// </summary>
    public sealed partial class LiveDecisionEvent
    {
        /// <summary>
        /// Default Value: decision.event
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveDecisionEventType.DecisionEvent</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveDecisionEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveDecisionEventType Type { get; set; } = global::tryAGI.OpenAI.LiveDecisionEventType.DecisionEvent;

        /// <summary>
        /// The unique ID of this Live server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delegation_id")]
        public string? DelegationId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("trigger_id")]
        public string? TriggerId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_event_type")]
        public global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1?, global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2?>? SourceEventType { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("source_event_id")]
        public string? SourceEventId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.LiveDecisionCompleted Event { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionEvent" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of this Live server event.
        /// </param>
        /// <param name="event"></param>
        /// <param name="delegationId"></param>
        /// <param name="triggerId"></param>
        /// <param name="sourceEventType"></param>
        /// <param name="sourceEventId"></param>
        /// <param name="type">
        /// Default Value: decision.event
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveDecisionEvent(
            string eventId,
            global::tryAGI.OpenAI.LiveDecisionCompleted @event,
            string? delegationId,
            string? triggerId,
            global::tryAGI.OpenAI.OneOf<global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant1?, global::tryAGI.OpenAI.LiveDecisionEventSourceEventTypeVariant1Variant2?>? sourceEventType,
            string? sourceEventId,
            global::tryAGI.OpenAI.LiveDecisionEventType type = global::tryAGI.OpenAI.LiveDecisionEventType.DecisionEvent)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.DelegationId = delegationId;
            this.TriggerId = triggerId;
            this.SourceEventType = sourceEventType;
            this.SourceEventId = sourceEventId;
            this.Event = @event ?? throw new global::System.ArgumentNullException(nameof(@event));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveDecisionEvent" /> class.
        /// </summary>
        public LiveDecisionEvent()
        {
        }

    }
}