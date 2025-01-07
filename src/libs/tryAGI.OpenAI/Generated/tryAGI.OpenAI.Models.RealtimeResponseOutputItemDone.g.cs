
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an Item is done streaming. Also emitted when a Response is interrupted, incomplete, or cancelled.
    /// </summary>
    public sealed partial class RealtimeResponseOutputItemDone
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_3536
        /// </summary>
        /// <example>event_3536</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.output_item.done".<br/>
        /// Example: response.output_item.done
        /// </summary>
        /// <example>response.output_item.done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseOutputItemDoneTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseOutputItemDoneType? Type { get; set; }

        /// <summary>
        /// The ID of the response to which the item belongs.<br/>
        /// Example: resp_001
        /// </summary>
        /// <example>resp_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        public int? OutputIndex { get; set; }

        /// <summary>
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        public global::tryAGI.OpenAI.RealtimeConversationItem? Item { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseOutputItemDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_3536
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.output_item.done".<br/>
        /// Example: response.output_item.done
        /// </param>
        /// <param name="responseId">
        /// The ID of the response to which the item belongs.<br/>
        /// Example: resp_001
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseOutputItemDone(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseOutputItemDoneType? type,
            string? responseId,
            int? outputIndex,
            global::tryAGI.OpenAI.RealtimeConversationItem? item)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.OutputIndex = outputIndex;
            this.Item = item;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseOutputItemDone" /> class.
        /// </summary>
        public RealtimeResponseOutputItemDone()
        {
        }
    }
}