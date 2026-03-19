
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Send this event to trigger a response generation.
    /// </summary>
    public sealed partial class ResponseCreatePayload
    {
        /// <summary>
        /// Optional client-generated ID.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseCreatePayloadTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.ResponseCreatePayloadType Type { get; set; }

        /// <summary>
        /// Configuration for a response.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::tryAGI.OpenAI.Realtime.ResponseConfig? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="response">
        /// Configuration for a response.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseCreatePayload(
            string? eventId,
            global::tryAGI.OpenAI.Realtime.ResponseCreatePayloadType type,
            global::tryAGI.OpenAI.Realtime.ResponseConfig? response)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseCreatePayload" /> class.
        /// </summary>
        public ResponseCreatePayload()
        {
        }
    }
}