
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Send this event to cancel an in-progress response.
    /// </summary>
    public sealed partial class RealtimeResponseCancel
    {
        /// <summary>
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_567
        /// </summary>
        /// <example>event_567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "response.cancel".<br/>
        /// Example: response.cancel
        /// </summary>
        /// <example>response.cancel</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeResponseCancelTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeResponseCancelType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCancel" /> class.
        /// </summary>
        /// <param name="eventId">
        /// Optional client-generated ID used to identify this event.<br/>
        /// Example: event_567
        /// </param>
        /// <param name="type">
        /// The event type, must be "response.cancel".<br/>
        /// Example: response.cancel
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeResponseCancel(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeResponseCancelType? type)
        {
            this.EventId = eventId;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeResponseCancel" /> class.
        /// </summary>
        public RealtimeResponseCancel()
        {
        }
    }
}