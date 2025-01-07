
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an error occurs.
    /// </summary>
    public sealed partial class RealtimeError
    {
        /// <summary>
        /// The unique ID of the server event.<br/>
        /// Example: event_890
        /// </summary>
        /// <example>event_890</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// The event type, must be "error".<br/>
        /// Example: error
        /// </summary>
        /// <example>error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeErrorType? Type { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        public global::tryAGI.OpenAI.RealtimeErrorDetails? Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.<br/>
        /// Example: event_890
        /// </param>
        /// <param name="type">
        /// The event type, must be "error".<br/>
        /// Example: error
        /// </param>
        /// <param name="error">
        /// Details of the error.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RealtimeError(
            string? eventId,
            global::tryAGI.OpenAI.RealtimeErrorType? type,
            global::tryAGI.OpenAI.RealtimeErrorDetails? error)
        {
            this.EventId = eventId;
            this.Type = type;
            this.Error = error;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeError" /> class.
        /// </summary>
        public RealtimeError()
        {
        }
    }
}