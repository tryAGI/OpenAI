
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Information about why the input could not be committed.
    /// </summary>
    public sealed partial class BetaResponseSteerFailedEventError
    {
        /// <summary>
        /// The error type. Always `invalid_request_error`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerFailedEventErrorTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType Type { get; set; }

        /// <summary>
        /// A machine-readable steering error code. Clients should handle unknown<br/>
        /// values because additional codes may be introduced. Known values include:<br/>
        /// - `response_not_found`: The target response is not available on this connection.<br/>
        /// - `invalid_input`: The event or input failed validation.<br/>
        /// - `steering_not_supported`: The model or response execution mode does not support steering.<br/>
        /// - `too_many_pending_steers`: Too much steering input is pending for the response.<br/>
        /// - `response_already_completed`: The response completed and is no longer accepting steering input.<br/>
        /// - `response_not_active`: The response is no longer accepting steering input.<br/>
        /// - `successor_creation_failed`: The successor response could not be created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaResponseSteerErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaResponseSteerErrorCode Code { get; set; }

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEventError" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable steering error code. Clients should handle unknown<br/>
        /// values because additional codes may be introduced. Known values include:<br/>
        /// - `response_not_found`: The target response is not available on this connection.<br/>
        /// - `invalid_input`: The event or input failed validation.<br/>
        /// - `steering_not_supported`: The model or response execution mode does not support steering.<br/>
        /// - `too_many_pending_steers`: Too much steering input is pending for the response.<br/>
        /// - `response_already_completed`: The response completed and is no longer accepting steering input.<br/>
        /// - `response_not_active`: The response is no longer accepting steering input.<br/>
        /// - `successor_creation_failed`: The successor response could not be created.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        /// <param name="type">
        /// The error type. Always `invalid_request_error`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaResponseSteerFailedEventError(
            global::tryAGI.OpenAI.BetaResponseSteerErrorCode code,
            string message,
            global::tryAGI.OpenAI.BetaResponseSteerFailedEventErrorType type)
        {
            this.Type = type;
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaResponseSteerFailedEventError" /> class.
        /// </summary>
        public BetaResponseSteerFailedEventError()
        {
        }

    }
}