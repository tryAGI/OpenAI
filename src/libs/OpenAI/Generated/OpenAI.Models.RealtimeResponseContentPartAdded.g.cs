
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned when a new content part is added to an assistant message item during response generation.
    /// </summary>
    public sealed partial class RealtimeResponseContentPartAdded
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_3738
        /// </summary>
        /// <example>event_3738</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.content_part.added".<br/>
        /// Example: response.content_part.added
        /// </summary>
        /// <example>response.content_part.added</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeResponseContentPartAddedTypeJsonConverter))]
        public global::OpenAI.RealtimeResponseContentPartAddedType? Type { get; set; }

        /// <summary>
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </summary>
        /// <example>resp_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the item to which the content part was added.<br/>
        /// Example: msg_007
        /// </summary>
        /// <example>msg_007</example>
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
        /// The index of the content part in the item's content array.<br/>
        /// Example: 0
        /// </summary>
        /// <example>0</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("content_index")]
        public int? ContentIndex { get; set; }

        /// <summary>
        /// The content part that was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("part")]
        public global::OpenAI.RealtimeContentPart? Part { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseContentPartAdded" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_3738
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.content_part.added".<br/>
        /// Example: response.content_part.added
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </param>
        /// <param name="itemId">
        /// The ID of the item to which the content part was added.<br/>
        /// Example: msg_007
        /// </param>
        /// <param name="outputIndex">
        /// The index of the output item in the response.<br/>
        /// Example: 0
        /// </param>
        /// <param name="contentIndex">
        /// The index of the content part in the item's content array.<br/>
        /// Example: 0
        /// </param>
        /// <param name="part">
        /// The content part that was added.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseContentPartAdded(
            string? eventId,
            global::OpenAI.RealtimeResponseContentPartAddedType? type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            global::OpenAI.RealtimeContentPart? part)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Part = part;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseContentPartAdded" /> class.
        /// </summary>
        public RealtimeResponseContentPartAdded()
        {
        }
    }
}