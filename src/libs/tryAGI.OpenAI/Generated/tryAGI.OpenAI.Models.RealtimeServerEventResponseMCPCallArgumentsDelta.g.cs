
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when MCP tool call arguments are updated during response generation.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseMCPCallArgumentsDelta
    {
        /// <summary>
        /// The JSON-encoded arguments delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Delta { get; set; }

        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the MCP tool call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ItemId { get; set; }

        /// <summary>
        /// If present, indicates the delta text was obfuscated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscation")]
        public string? Obfuscation { get; set; }

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The event type, must be `response.mcp_call_arguments.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseMCPCallArgumentsDelta" /> class.
        /// </summary>
        /// <param name="delta">
        /// The JSON-encoded arguments delta.
        /// </param>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="itemId">
        /// The ID of the MCP tool call item.
        /// </param>
        /// <param name="obfuscation">
        /// If present, indicates the delta text was obfuscated.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.mcp_call_arguments.delta`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventResponseMCPCallArgumentsDelta(
            string delta,
            string eventId,
            string itemId,
            int outputIndex,
            string responseId,
            string? obfuscation,
            global::tryAGI.OpenAI.RealtimeServerEventResponseMCPCallArgumentsDeltaType type)
        {
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Obfuscation = obfuscation;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseMCPCallArgumentsDelta" /> class.
        /// </summary>
        public RealtimeServerEventResponseMCPCallArgumentsDelta()
        {
        }
    }
}