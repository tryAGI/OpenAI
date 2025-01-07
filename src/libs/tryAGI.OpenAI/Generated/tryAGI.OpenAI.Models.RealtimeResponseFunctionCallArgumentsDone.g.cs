
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the model-generated function call arguments are done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeResponseFunctionCallArgumentsDone
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_5556
        /// </summary>
        /// <example>event_5556</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.function_call_arguments.done".<br/>
        /// Example: response.function_call_arguments.done
        /// </summary>
        /// <example>response.function_call_arguments.done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseFunctionCallArgumentsDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseFunctionCallArgumentsDoneType? Type { get; set; }

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
        /// The final arguments as a JSON string.<br/>
        /// Example: {"location": "San Francisco"}
        /// </summary>
        /// <example>{"location": "San Francisco"}</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("arguments")]
        public string? Arguments { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseFunctionCallArgumentsDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_5556
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.function_call_arguments.done".<br/>
        /// Example: response.function_call_arguments.done
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
        /// <param name="arguments">
        /// The final arguments as a JSON string.<br/>
        /// Example: {"location": "San Francisco"}
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseFunctionCallArgumentsDone(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseFunctionCallArgumentsDoneType? type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            string? callId,
            string? arguments)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.CallId = callId;
            this.Arguments = arguments;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseFunctionCallArgumentsDone" /> class.
        /// </summary>
        public RealtimeResponseFunctionCallArgumentsDone()
        {
        }
    }
}