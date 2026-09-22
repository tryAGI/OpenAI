
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when accepted steering input remains queued after the target<br/>
    /// response completes. The server still owns the input. Do not resend it.<br/>
    /// The successor's `response.created` event is the commit point.<br/>
    /// When `reason` is `waiting_for_required_input`, this event follows<br/>
    /// `response.completed` while the response waits for the tool results or<br/>
    /// approval decisions identified by `required_input`. Copy those stubs, fill<br/>
    /// their result fields using the ordinary `response.create` input schemas,<br/>
    /// and submit one continuation per parent with the same `previous_response_id`<br/>
    /// and WebSocket lane. Use saved results without rerunning tools. The queued<br/>
    /// steering input is prepended in submission order to the continuation's<br/>
    /// input. That explicit request retains its own settings.<br/>
    /// This notification is emitted at most once per steering submission. Multiple<br/>
    /// submissions for the same parent can report the same required inputs; they<br/>
    /// do not each require a separate continuation.
    /// </summary>
    public sealed partial class ResponseSteerPendingEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.steer.pending`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerPendingEventType Type { get; set; }

        /// <summary>
        /// The sequence number for this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The steering submission that remains queued.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("steer")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseSteerPendingEventSteer Steer { get; set; }

        /// <summary>
        /// An extensible enum describing why accepted steering input is still queued.<br/>
        /// Clients should handle unknown values because additional reasons may be<br/>
        /// introduced. Known values include:<br/>
        /// - `waiting_for_required_input`: The response is waiting for the tool results or approval decisions identified by `required_input`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("reason")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerPendingReasonJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseSteerPendingReason Reason { get; set; }

        /// <summary>
        /// Input stubs identifying outstanding client-owned tool results or<br/>
        /// approval decisions. Each stub contains identifying fields only; the<br/>
        /// client supplies the result before including it in `response.create`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("required_input")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput> RequiredInput { get; set; }

        /// <summary>
        /// The WebSocket lane that emitted this event. This field is present when<br/>
        /// the target response's `response.create` event supplied a `stream_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerPendingEvent" /> class.
        /// </summary>
        /// <param name="sequenceNumber">
        /// The sequence number for this event.
        /// </param>
        /// <param name="steer">
        /// The steering submission that remains queued.
        /// </param>
        /// <param name="reason">
        /// An extensible enum describing why accepted steering input is still queued.<br/>
        /// Clients should handle unknown values because additional reasons may be<br/>
        /// introduced. Known values include:<br/>
        /// - `waiting_for_required_input`: The response is waiting for the tool results or approval decisions identified by `required_input`.
        /// </param>
        /// <param name="requiredInput">
        /// Input stubs identifying outstanding client-owned tool results or<br/>
        /// approval decisions. Each stub contains identifying fields only; the<br/>
        /// client supplies the result before including it in `response.create`.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.steer.pending`.
        /// </param>
        /// <param name="streamId">
        /// The WebSocket lane that emitted this event. This field is present when<br/>
        /// the target response's `response.create` event supplied a `stream_id`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerPendingEvent(
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseSteerPendingEventSteer steer,
            global::tryAGI.OpenAI.ResponseSteerPendingReason reason,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ResponseSteerRequiredInput> requiredInput,
            global::tryAGI.OpenAI.ResponseSteerPendingEventType type,
            string? streamId)
        {
            this.Type = type;
            this.SequenceNumber = sequenceNumber;
            this.Steer = steer ?? throw new global::System.ArgumentNullException(nameof(steer));
            this.Reason = reason;
            this.RequiredInput = requiredInput ?? throw new global::System.ArgumentNullException(nameof(requiredInput));
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerPendingEvent" /> class.
        /// </summary>
        public ResponseSteerPendingEvent()
        {
        }

    }
}