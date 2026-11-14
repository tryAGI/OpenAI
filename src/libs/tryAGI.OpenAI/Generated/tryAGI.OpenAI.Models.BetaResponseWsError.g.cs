
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when an error occurs while processing a Responses WebSocket request.
    /// </summary>
    public sealed partial class BetaResponseWsError
    {
        /// <summary>
        /// The agent that owns this multi-agent streaming event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the event. Always `error`.
        /// </summary>
        /// <default>"error"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "error";

        /// <summary>
        /// The HTTP status code associated with a WebSocket protocol error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public int? Status { get; set; }

        /// <summary>
        /// The sequence number of an error emitted by the response stream.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        public int? SequenceNumber { get; set; }

        /// <summary>
        /// Details about the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaErrorPayload Error { get; set; }

        /// <summary>
        /// The WebSocket lane that emitted this event. This field is present when the<br/>
        /// originating `response.create` event supplied a `stream_id`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("stream_id")]
        public string? StreamId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWsError" /> class.
        /// </summary>
        /// <param name="error">
        /// Details about the error.
        /// </param>
        /// <param name="agent">
        /// The agent that owns this multi-agent streaming event.
        /// </param>
        /// <param name="status">
        /// The HTTP status code associated with a WebSocket protocol error.
        /// </param>
        /// <param name="sequenceNumber">
        /// The sequence number of an error emitted by the response stream.
        /// </param>
        /// <param name="streamId">
        /// The WebSocket lane that emitted this event. This field is present when the<br/>
        /// originating `response.create` event supplied a `stream_id`.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseWsError(
            global::tryAGI.OpenAI.BetaErrorPayload error,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            int? status,
            int? sequenceNumber,
            string? streamId,
            string type = "error")
        {
            this.Agent = agent;
            this.Type = type;
            this.Status = status;
            this.SequenceNumber = sequenceNumber;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
            this.StreamId = streamId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseWsError" /> class.
        /// </summary>
        public BetaResponseWsError()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaResponseWsError"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaResponseWsError FromError(global::tryAGI.OpenAI.BetaErrorPayload error)
        {
            return new BetaResponseWsError
            {
                Error = error,
            };
        }

    }
}