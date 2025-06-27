
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An event that is emitted when a response finishes as incomplete.
    /// </summary>
    public sealed partial class ResponseIncompleteEvent
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Response Response { get; set; }

        /// <summary>
        /// The sequence number of this event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("sequence_number")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int SequenceNumber { get; set; }

        /// <summary>
        /// The type of the event. Always `response.incomplete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseIncompleteEventType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        /// <param name="response"></param>
        /// <param name="sequenceNumber">
        /// The sequence number of this event.
        /// </param>
        /// <param name="type">
        /// The type of the event. Always `response.incomplete`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseIncompleteEvent(
            global::tryAGI.OpenAI.Response response,
            int sequenceNumber,
            global::tryAGI.OpenAI.ResponseIncompleteEventType type)
        {
            this.Response = response;
            this.SequenceNumber = sequenceNumber;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        public ResponseIncompleteEvent()
        {
        }
    }
}