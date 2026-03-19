
#nullable enable

namespace tryAGI.OpenAI.Realtime
{
    /// <summary>
    /// Returned when a Response is done streaming.
    /// </summary>
    public sealed partial class ResponseDonePayload
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.Realtime.JsonConverters.ResponseDonePayloadTypeJsonConverter))]
        public global::tryAGI.OpenAI.Realtime.ResponseDonePayloadType Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::tryAGI.OpenAI.Realtime.Response? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDonePayload" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="type">
        /// The event type.
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ResponseDonePayload(
            string eventId,
            global::tryAGI.OpenAI.Realtime.ResponseDonePayloadType type,
            global::tryAGI.OpenAI.Realtime.Response? response)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ResponseDonePayload" /> class.
        /// </summary>
        public ResponseDonePayload()
        {
        }
    }
}