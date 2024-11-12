
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// Returned when a Response is done streaming. Always emitted, no matter the final state.
    /// </summary>
    public sealed partial class RealtimeResponseDone
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_3132
        /// </summary>
        /// <example>event_3132</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.done".<br/>
        /// Example: response.done
        /// </summary>
        /// <example>response.done</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RealtimeResponseDoneTypeJsonConverter))]
        public global::OpenAI.RealtimeResponseDoneType? Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::OpenAI.RealtimeResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseDone" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_3132
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.done".<br/>
        /// Example: response.done
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeResponseDone(
            string? eventId,
            global::OpenAI.RealtimeResponseDoneType? type,
            global::OpenAI.RealtimeResponse? response)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseDone" /> class.
        /// </summary>
        public RealtimeResponseDone()
        {
        }
    }
}