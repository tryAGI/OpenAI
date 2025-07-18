
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a new Item is created during Response generation.
    /// </summary>
    public sealed partial class RealtimeServerEventResponseOutputItemAdded
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("item")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeConversationItem Item { get; set; }

        /// <summary>
        /// The index of the output item in the Response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("output_index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int OutputIndex { get; set; }

        /// <summary>
        /// The ID of the Response to which the item belongs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResponseId { get; set; }

        /// <summary>
        /// The event type, must be `response.output_item.added`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeServerEventResponseOutputItemAddedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseOutputItemAdded" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="item">
        /// A realtime Item is of three types: message, function_call, or function_call_output.<br/>
        /// A message item can contain text or audio.<br/>
        /// A function_call item indicates a model's desire to call a function, which is the only tool supported for now<br/>
        /// A function_call_output item indicates a function response.<br/>
        /// The client may add and remove message and function_call_output Items using conversation.item.create and conversation.item.delete.
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the Response.
        /// </param>
        /// <param name="responseId">
        /// The ID of the Response to which the item belongs.
        /// </param>
        /// <param name="type">
        /// The event type, must be `response.output_item.added`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeServerEventResponseOutputItemAdded(
            string eventId,
            global::tryAGI.OpenAI.RealtimeConversationItem item,
            int outputIndex,
            string responseId,
            global::tryAGI.OpenAI.RealtimeServerEventResponseOutputItemAddedType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Item = item ?? throw new global::System.ArgumentNullException(nameof(item));
            this.OutputIndex = outputIndex;
            this.ResponseId = responseId ?? throw new global::System.ArgumentNullException(nameof(responseId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeServerEventResponseOutputItemAdded" /> class.
        /// </summary>
        public RealtimeServerEventResponseOutputItemAdded()
        {
        }
    }
}