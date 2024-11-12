
#nullable enable

namespace OpenAI
{
    /// <summary>
    /// The last error associated with this run. Will be `null` if there are no errors.
    /// </summary>
    public sealed partial class RunObjectLastError
    {
        /// <summary>
        /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::OpenAI.JsonConverters.RunObjectLastErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::OpenAI.RunObjectLastErrorCode Code { get; set; }

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
        /// Initializes a new instance of the <see cref="RunObjectLastError" /> class.
        /// </summary>
        /// <param name="code">
        /// One of `server_error`, `rate_limit_exceeded`, or `invalid_prompt`.
        /// </param>
        /// <param name="message">
        /// A human-readable description of the error.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public RunObjectLastError(
            global::OpenAI.RunObjectLastErrorCode code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="RunObjectLastError" /> class.
        /// </summary>
        public RunObjectLastError()
        {
        }
    }
}