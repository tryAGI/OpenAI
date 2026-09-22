
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Emitted when a turn or session fails.
    /// </summary>
    public sealed partial class SessionEventError
    {
        /// <summary>
        /// The type of the object. Always `error`.<br/>
        /// Default Value: error
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionEventErrorType.Error</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionEventErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.SessionEventErrorType Type { get; set; } = global::tryAGI.OpenAI.SessionEventErrorType.Error;

        /// <summary>
        /// The unique ID of the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The ID of the session associated with the event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("session_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string SessionId { get; set; }

        /// <summary>
        /// The error that occurred.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionErrorResource Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventError" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the event.
        /// </param>
        /// <param name="sessionId">
        /// The ID of the session associated with the event.
        /// </param>
        /// <param name="error">
        /// The error that occurred.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `error`.<br/>
        /// Default Value: error
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEventError(
            string eventId,
            string sessionId,
            global::tryAGI.OpenAI.SessionErrorResource error,
            global::tryAGI.OpenAI.SessionEventErrorType type = global::tryAGI.OpenAI.SessionEventErrorType.Error)
        {
            this.Type = type;
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.SessionId = sessionId ?? throw new global::System.ArgumentNullException(nameof(sessionId));
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEventError" /> class.
        /// </summary>
        public SessionEventError()
        {
        }

    }
}