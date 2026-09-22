
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// An error reported while preparing a session environment.
    /// </summary>
    public sealed partial class SessionEnvironmentErrorResource
    {
        /// <summary>
        /// The error type.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Type { get; set; }

        /// <summary>
        /// A machine-readable error code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Code { get; set; }

        /// <summary>
        /// A human-readable error message.
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
        /// Initializes a new instance of the <see cref="SessionEnvironmentErrorResource" /> class.
        /// </summary>
        /// <param name="type">
        /// The error type.
        /// </param>
        /// <param name="code">
        /// A machine-readable error code.
        /// </param>
        /// <param name="message">
        /// A human-readable error message.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionEnvironmentErrorResource(
            string type,
            string code,
            string message)
        {
            this.Type = type ?? throw new global::System.ArgumentNullException(nameof(type));
            this.Code = code ?? throw new global::System.ArgumentNullException(nameof(code));
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionEnvironmentErrorResource" /> class.
        /// </summary>
        public SessionEnvironmentErrorResource()
        {
        }

    }
}