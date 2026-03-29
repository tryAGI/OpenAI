
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Returned when an error occurs, which could be a client problem or a server<br/>
    /// problem. Most errors are recoverable and the session will stay open, we<br/>
    /// recommend to implementors to monitor and log error messages by default.
    /// </summary>
    public sealed partial class RealtimeBetaServerEventError
    {
        /// <summary>
        /// The unique ID of the server event.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("event_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EventId { get; set; }

        /// <summary>
        /// The event type, must be `error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RealtimeBetaServerEventErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType Type { get; set; }

        /// <summary>
        /// Details of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("error")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError Error { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventError" /> class.
        /// </summary>
        /// <param name="eventId">
        /// The unique ID of the server event.
        /// </param>
        /// <param name="error">
        /// Details of the error.
        /// </param>
        /// <param name="type">
        /// The event type, must be `error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RealtimeBetaServerEventError(
            string eventId,
            global::tryAGI.OpenAI.RealtimeBetaServerEventErrorError error,
            global::tryAGI.OpenAI.RealtimeBetaServerEventErrorType type)
        {
            this.EventId = eventId ?? throw new global::System.ArgumentNullException(nameof(eventId));
            this.Type = type;
            this.Error = error ?? throw new global::System.ArgumentNullException(nameof(error));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RealtimeBetaServerEventError" /> class.
        /// </summary>
        public RealtimeBetaServerEventError()
        {
        }
    }
}