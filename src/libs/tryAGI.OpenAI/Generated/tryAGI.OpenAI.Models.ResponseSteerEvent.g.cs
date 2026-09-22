
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Queues user input to steer a response on this WebSocket connection. Input<br/>
    /// can contain text, images, and files. Steering is supported only for<br/>
    /// single-agent responses on models and execution modes that support steering.<br/>
    /// Responses bound to a conversation or using automatic compaction do not<br/>
    /// support steering.<br/>
    /// A `response.steer.accepted` event acknowledges that the server owns the<br/>
    /// queued input, not that it has been applied. The successor's `response.created`<br/>
    /// event is the commit point. Input that cannot be committed is returned in<br/>
    /// `response.steer.failed`.<br/>
    /// Steering may cause the active response to finish at a safe output boundary<br/>
    /// with `response.incomplete` and `incomplete_details.reason` set to `steered`,<br/>
    /// followed automatically by a successor `response.created`. Normal completion<br/>
    /// can also be followed by an automatic successor. Automatic successors inherit<br/>
    /// the previous response's settings and continue from it with the queued input.<br/>
    /// If the response stops for client-owned tool output or approval, accepted<br/>
    /// steering input remains queued and `response.steer.pending` is emitted after<br/>
    /// `response.completed`. Fill the `required_input` stubs from that event with<br/>
    /// saved tool results or approval decisions, and send one explicit<br/>
    /// `response.create` per parent with the same `previous_response_id` and<br/>
    /// WebSocket lane. Do not rerun tools or resend accepted steering input. The<br/>
    /// queued input is prepended in submission order to that request's input, and<br/>
    /// the explicit request retains its own settings.<br/>
    /// This event accepts only `type`, `previous_response_id`, and `input`. Do not<br/>
    /// send `stream_id`; the target response determines the WebSocket lane.
    /// </summary>
    public sealed partial class ResponseSteerEvent
    {
        /// <summary>
        /// The event discriminator. Always `response.steer`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseSteerEventType Type { get; set; }

        /// <summary>
        /// The ID of the response to steer on this WebSocket connection.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string PreviousResponseId { get; set; }

        /// <summary>
        /// Input to queue for a continuation of the response. Uses the same string or<br/>
        /// input-item shape as `response.create.input`, with a non-empty array when<br/>
        /// supplying input items.<br/>
        /// Steering accepts only messages with the `user` role. Each message may<br/>
        /// contain only `type`, `role`, and `content`, with `content` as a string or an<br/>
        /// array of `input_text`, `input_image`, and `input_file` parts. The optional<br/>
        /// `type` must be `message`. Other roles, tool outputs, and item types are not<br/>
        /// supported for steering.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseSteerInputJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ResponseSteerInput Input { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerEvent" /> class.
        /// </summary>
        /// <param name="previousResponseId">
        /// The ID of the response to steer on this WebSocket connection.
        /// </param>
        /// <param name="input">
        /// Input to queue for a continuation of the response. Uses the same string or<br/>
        /// input-item shape as `response.create.input`, with a non-empty array when<br/>
        /// supplying input items.<br/>
        /// Steering accepts only messages with the `user` role. Each message may<br/>
        /// contain only `type`, `role`, and `content`, with `content` as a string or an<br/>
        /// array of `input_text`, `input_image`, and `input_file` parts. The optional<br/>
        /// `type` must be `message`. Other roles, tool outputs, and item types are not<br/>
        /// supported for steering.
        /// </param>
        /// <param name="type">
        /// The event discriminator. Always `response.steer`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseSteerEvent(
            string previousResponseId,
            global::tryAGI.OpenAI.ResponseSteerInput input,
            global::tryAGI.OpenAI.ResponseSteerEventType type)
        {
            this.Type = type;
            this.PreviousResponseId = previousResponseId ?? throw new global::System.ArgumentNullException(nameof(previousResponseId));
            this.Input = input;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseSteerEvent" /> class.
        /// </summary>
        public ResponseSteerEvent()
        {
        }

    }
}