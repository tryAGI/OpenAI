
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the model-generated function call arguments are updated.
    /// </summary>
    public sealed partial class RealtimeResponseFunctionCallArgumentsDelta
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_5354
        /// </summary>
        /// <example>event_5354</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.function_call_arguments.delta".<br/>
        /// Example: response.function_call_arguments.delta
        /// </summary>
        /// <example>response.function_call_arguments.delta</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseFunctionCallArgumentsDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseFunctionCallArgumentsDeltaType? Type { get; set; }

        /// <summary>
        /// The ID of the response.<br/>
        /// Example: resp_002
        /// </summary>
        /// <example>resp_002</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the function call item.<br/>
        /// Example: fc_001
        /// </summary>
        /// <example>fc_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("item_id")]
        public string? ItemId { get; set; }

        /// <summary>
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// The ID of the function call.<br/>
        /// Example: call_001
        /// </summary>
        /// <example>call_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("call_id")]
        public string? CallId { get; set; }

        /// <summary>
        /// The arguments delta as a JSON string.<br/>
        /// Example: {"location": "San"
        /// </summary>
        /// <example>{"location": "San"</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseFunctionCallArgumentsDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_5354
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.function_call_arguments.delta".<br/>
        /// Example: response.function_call_arguments.delta
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.<br/>
        /// Example: resp_002
        /// </param>
        /// <param name="itemId">
        /// The ID of the function call item.<br/>
        /// Example: fc_001
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </param>
        /// <param name="callId">
        /// The ID of the function call.<br/>
        /// Example: call_001
        /// </param>
        /// <param name="delta">
        /// The arguments delta as a JSON string.<br/>
        /// Example: {"location": "San"
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseFunctionCallArgumentsDelta(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseFunctionCallArgumentsDeltaType? type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            string? callId,
            string? delta)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.CallId = callId;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseFunctionCallArgumentsDelta" /> class.
        /// </summary>
        public RealtimeResponseFunctionCallArgumentsDelta()
        {
        }
    }
}