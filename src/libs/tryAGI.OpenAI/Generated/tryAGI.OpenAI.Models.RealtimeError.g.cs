
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an error occurs.<br/>
    /// Example: {"event_id":"event_890","type":"error","error":{"type":"invalid_request_error","code":"invalid_event","message":"The \u0027type\u0027 field is missing.","param":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event_id":"event_567"}}
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
        /// Details of the error.<br/>
        /// Example: {"type":"invalid_request_error","code":"invalid_event","message":"The \u0027type\u0027 field is missing.","param":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event_id":"event_567"}
        /// </summary>
        /// <example>{"type":"invalid_request_error","code":"invalid_event","message":"The \u0027type\u0027 field is missing.","param":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event_id":"event_567"}</example>
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
        /// Details of the error.<br/>
        /// Example: {"type":"invalid_request_error","code":"invalid_event","message":"The \u0027type\u0027 field is missing.","param":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event_id":"event_567"}
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
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