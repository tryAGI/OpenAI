
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An error that occurred while generating the response.
    /// </summary>
    public sealed partial class Error22
    {
        /// <summary>
        /// A machine-readable error code that was returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable description of the error that was returned.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The Retry-After and Retry-After-Ms headers returned with the original error, if any.
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
        /// Initializes a new instance of the <see cref="Error22" /> class.
        /// </summary>
        /// <param name="code">
        /// A machine-readable error code that was returned.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error that was returned.
        /// </param>
        /// <param name="headers">
        /// The Retry-After and Retry-After-Ms headers returned with the original error, if any.
        /// </param>
        /// <param name="misalignment"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Error22(
            string code,
            string message,
            global::System.Collections.Generic.Dictionary<string, string>? headers,
            global::tryAGI.OpenAI.MisalignmentErrorDetailsResource? misalignment)
        {
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Headers = headers;
            this.Misalignment = misalignment;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Error22" /> class.
        /// </summary>
        public Error22()
        {
        }

    }
}