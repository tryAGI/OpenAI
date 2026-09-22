
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details of an error encountered by the Live session, including the affected parameter or client command when available.
    /// </summary>
    public sealed partial class LiveLiveError
    {
        /// <summary>
        /// The category of error, such as `invalid_request_error` for an invalid Live client command.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A machine-readable code identifying the Live error, such as `unknown_parameter`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable explanation of the Live error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The parameter that caused the error, when applicable, such as `session.voice`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The event_id of the client command that caused the error, when supplied.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("client_event_id")]
        public string? ClientEventId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveLiveError" /> class.
        /// </summary>
        /// <param name="type">
        /// The category of error, such as `invalid_request_error` for an invalid Live client command.
        /// </param>
        /// <param name="code">
        /// A machine-readable code identifying the Live error, such as `unknown_parameter`.
        /// </param>
        /// <param name="message">
        /// A human-readable explanation of the Live error.
        /// </param>
        /// <param name="param">
        /// The parameter that caused the error, when applicable, such as `session.voice`.
        /// </param>
        /// <param name="clientEventId">
        /// The event_id of the client command that caused the error, when supplied.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveLiveError(
            string type,
            string code,
            string message,
            string? param,
            string? clientEventId)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.ClientEventId = clientEventId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveLiveError" /> class.
        /// </summary>
        public LiveLiveError()
        {
        }

    }
}