
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An event that is emitted when a response finishes as incomplete.
    /// </summary>
    public sealed partial class ResponseIncompleteEvent
    {
        /// <summary>
        /// The type of the event. Always `response.incomplete`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseIncompleteEventTypeJsonConverter))]
        public global::tryAGI.OpenAI.ResponseIncompleteEventType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ResponseJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Response Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseIncompleteEvent" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the event. Always `response.incomplete`.
        /// </param>
        /// <param name="response"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseIncompleteEvent(
            global::tryAGI.OpenAI.Response response,
            global::tryAGI.OpenAI.ResponseIncompleteEventType type)
        {
            this.Response = response;
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