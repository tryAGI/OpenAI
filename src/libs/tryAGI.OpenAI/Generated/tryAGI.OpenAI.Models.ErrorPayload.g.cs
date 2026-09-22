
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An error payload that was emitted for a streaming error event.
    /// </summary>
    public sealed partial class ErrorPayload
    {
        /// <summary>
        /// The error type that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// The human-readable error message that was emitted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// The response headers that were emitted with the error, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("headers")]
        public global::System.Collections.Generic.Dictionary<string, string>? Headers { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("misalignment")]
        public global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? Misalignment { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        /// <param name="type">
        /// The error type that was emitted.
        /// </param>
        /// <param name="message">
        /// The human-readable error message that was emitted.
        /// </param>
        /// <param name="code"></param>
        /// <param name="param"></param>
        /// <param name="headers">
        /// The response headers that were emitted with the error, if any.
        /// </param>
        /// <param name="misalignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ErrorPayload(
            string type,
            string message,
            string? code,
            string? param,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? misalignment)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
            this.Headers = headers;
            this.Misalignment = misalignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ErrorPayload" /> class.
        /// </summary>
        public ErrorPayload()
        {
        }

    }
}