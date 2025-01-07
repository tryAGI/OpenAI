
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when the text value of a "text" content part is updated.
    /// </summary>
    public sealed partial class RealtimeResponseTextDelta
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_4142
        /// </summary>
        /// <example>event_4142</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.text.delta".<br/>
        /// Example: response.text.delta
        /// </summary>
        /// <example>response.text.delta</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseTextDeltaTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseTextDeltaType? Type { get; set; }

        /// <summary>
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </summary>
        /// <example>resp_001</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("response_id")]
        public string? ResponseId { get; set; }

        /// <summary>
        /// The ID of the item.<br/>
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
        /// The text delta.<br/>
        /// Example: Sure, I can h
        /// </summary>
        /// <example>Sure, I can h</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("delta")]
        public string? Delta { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseTextDelta" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_4142
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.text.delta".<br/>
        /// Example: response.text.delta
        /// </param>
        /// <param name="responseId">
        /// The ID of the response.<br/>
        /// Example: resp_001
        /// </param>
        /// <param name="itemId">
        /// The ID of the item.<br/>
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
        /// <param name="delta">
        /// The text delta.<br/>
        /// Example: Sure, I can h
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseTextDelta(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseTextDeltaType? type,
            string? responseId,
            string? itemId,
            int? outputIndex,
            int? contentIndex,
            string? delta)
        {
            this.EventId = eventId;
            this.Type = type;
            this.ResponseId = responseId;
            this.ItemId = itemId;
            this.OutputIndex = outputIndex;
            this.ContentIndex = contentIndex;
            this.Delta = delta;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseTextDelta" /> class.
        /// </summary>
        public RealtimeResponseTextDelta()
        {
        }
    }
}