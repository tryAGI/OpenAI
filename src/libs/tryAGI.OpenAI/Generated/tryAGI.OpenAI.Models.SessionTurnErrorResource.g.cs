
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A customer-safe error describing why a session request failed.
    /// </summary>
    public sealed partial class SessionTurnErrorResource
    {
        /// <summary>
        /// A stable, machine-readable failure category.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("code")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionTurnErrorCodeResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.SessionTurnErrorCodeResource Code { get; set; }

        /// <summary>
        /// A customer-safe explanation of the failure.
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
        /// Initializes a new instance of the <see cref="SessionTurnErrorResource" /> class.
        /// </summary>
        /// <param name="code">
        /// A stable, machine-readable failure category.
        /// </param>
        /// <param name="message">
        /// A customer-safe explanation of the failure.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionTurnErrorResource(
            global::tryAGI.OpenAI.SessionTurnErrorCodeResource code,
            string message)
        {
            this.Code = code;
            this.Message = message ?? throw new global::System.ArgumentNullException(nameof(message));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionTurnErrorResource" /> class.
        /// </summary>
        public SessionTurnErrorResource()
        {
        }

    }
}