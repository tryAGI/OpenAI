
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of the error.<br/>
    /// Example: {"type":"invalid_request_error","code":"invalid_event","message":"The \u0027type\u0027 field is missing.","param":"openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464","event_id":"event_567"}
    /// </summary>
    public sealed partial class RealtimeErrorDetails
    {
        /// <summary>
        /// The type of error (e.g., "invalid_request_error", "server_error").<br/>
        /// Example: invalid_request_error
        /// </summary>
        /// <example>invalid_request_error</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string? Type { get; set; }

        /// <summary>
        /// Error code, if any.<br/>
        /// Example: invalid_event
        /// </summary>
        /// <example>invalid_event</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A human-readable error message.<br/>
        /// Example: The 'type' field is missing.
        /// </summary>
        /// <example>The 'type' field is missing.</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        public string? Message { get; set; }

        /// <summary>
        /// Parameter related to the error, if any.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </summary>
        /// <example>openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The event_id of the client event that caused the error, if applicable.<br/>
        /// Example: event_567
        /// </summary>
        /// <example>event_567</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        public string? EventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeErrorDetails" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of error (e.g., "invalid_request_error", "server_error").<br/>
        /// Example: invalid_request_error
        /// </param>
        /// <param name="code">
        /// Error code, if any.<br/>
        /// Example: invalid_event
        /// </param>
        /// <param name="message">
        /// A human-readable error message.<br/>
        /// Example: The 'type' field is missing.
        /// </param>
        /// <param name="param">
        /// Parameter related to the error, if any.<br/>
        /// Example: openapi-json-null-sentinel-value-2BF93600-0FE4-4250-987A-E5DDB203E464
        /// </param>
        /// <param name="eventId">
        /// The event_id of the client event that caused the error, if applicable.<br/>
        /// Example: event_567
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeErrorDetails(
            string? type,
            string? code,
            string? message,
            string? param,
            string? eventId)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message;
            this.Param = param;
            this.EventId = eventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeErrorDetails" /> class.
        /// </summary>
        public RealtimeErrorDetails()
        {
        }
    }
}