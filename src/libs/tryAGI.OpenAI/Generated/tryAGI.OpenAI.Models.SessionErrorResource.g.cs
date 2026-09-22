
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An error payload with the same public fields as Responses API streaming errors.
    /// </summary>
    public sealed partial class SessionErrorResource
    {
        /// <summary>
        /// The error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// The machine-readable error code, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        public string? Code { get; set; }

        /// <summary>
        /// A customer-safe explanation of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Message { get; set; }

        /// <summary>
        /// The request parameter associated with the error, if any.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("param")]
        public string? Param { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionErrorResource" /> class.
        /// </summary>
        /// <param name="type">
        /// The error type.
        /// </param>
        /// <param name="message">
        /// A customer-safe explanation of the error.
        /// </param>
        /// <param name="code">
        /// The machine-readable error code, if any.
        /// </param>
        /// <param name="param">
        /// The request parameter associated with the error, if any.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionErrorResource(
            string type,
            string message,
            string? code,
            string? param)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
            this.Param = param;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionErrorResource" /> class.
        /// </summary>
        public SessionErrorResource()
        {
        }

    }
}