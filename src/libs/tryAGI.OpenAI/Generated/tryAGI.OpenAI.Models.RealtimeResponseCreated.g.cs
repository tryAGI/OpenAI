
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when a new Response is created. The first event of response creation, where the response is in an initial state of "in_progress".
    /// </summary>
    public sealed partial class RealtimeResponseCreated
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_2930
        /// </summary>
        /// <example>event_2930</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.created".<br/>
        /// Example: response.created
        /// </summary>
        /// <example>response.created</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCreatedTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseCreatedType? Type { get; set; }

        /// <summary>
        /// The response resource.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("response")]
        public global::tryAGI.OpenAI.RealtimeResponse? Response { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreated" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_2930
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.created".<br/>
        /// Example: response.created
        /// </param>
        /// <param name="response">
        /// The response resource.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCreated(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseCreatedType? type,
            global::tryAGI.OpenAI.RealtimeResponse? response)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Response = response;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCreated" /> class.
        /// </summary>
        public RealtimeResponseCreated()
        {
        }
    }
}