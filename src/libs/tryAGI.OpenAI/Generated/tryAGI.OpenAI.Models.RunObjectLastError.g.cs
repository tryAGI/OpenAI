
#nullable enable

namespace tryAGI.OpenAI
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
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RunObjectLastErrorCodeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.RunObjectLastErrorCode Code { get; set; } = default!;

        /// <summary>
        /// A human-readable description of the error.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("message")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Message { get; set; } = default!;

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
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public RunObjectLastError(
            global::tryAGI.OpenAI.RunObjectLastErrorCode code,
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