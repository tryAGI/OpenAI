
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when MCP tool call arguments are updated during response generation.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventResponseMCPCallArgumentsDelta
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string EventId { get; set; } = default!;

        /// <summary>
        /// The event type, must be `response.mcp_call_arguments.delta`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType Type { get; set; }

        /// <summary>
        /// The ID of the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ResponseId { get; set; } = default!;

        /// <summary>
        /// The ID of the MCP tool call item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ItemId { get; set; } = default!;

        /// <summary>
        /// The index of the output item in the response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public int OutputIndex { get; set; } = default!;

        /// <summary>
        /// The JSON-encoded arguments delta.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Delta { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("obfuscation")]
        public string? Obfuscation { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventResponseMCPCallArgumentsDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.mcp_call_arguments.delta`.
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.
        /// </param>
        /// <param name="itemId">
        /// The ID of the MCP tool call item.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.
        /// </param>
        /// <param name="delta">
        /// The JSON-encoded arguments delta.
        /// </param>
        /// <param name="obfuscation"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventResponseMCPCallArgumentsDelta(
            string eventId,
            string responseId,
            string itemId,
            int outputIndex,
            string delta,
            global::tryAGI.OpenAI.RealtimeBetaServerEventResponseMCPCallArgumentsDeltaType type,
            string? obfuscation)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.ItemId = itemId ?? throw new global::System.ArgumentNullException(nameof(itemId));
            this.OutputIndex = outputIndex;
            this.Delta = delta ?? throw new global::System.ArgumentNullException(nameof(delta));
            this.Type = type;
            this.Obfuscation = obfuscation;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventResponseMCPCallArgumentsDelta" /> class.
        /// </summary>
        public RealtimeBetaServerEventResponseMCPCallArgumentsDelta()
        {
        }
    }
}