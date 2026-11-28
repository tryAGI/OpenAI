
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The payload used to update the API key.
    /// </summary>
    public sealed partial class AuditLogApiKeyUpdatedChangesRequested
    {
        /// <summary>
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Number of seconds from the update request until the API key expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdatedChangesRequested" /> class.
        /// </summary>
        /// <param name="scopes">
        /// A list of scopes allowed for the API key, e.g. `["api.model.request"]`
        /// </param>
        /// <param name="expiresInSeconds">
        /// Number of seconds from the update request until the API key expires.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AuditLogApiKeyUpdatedChangesRequested(
            global::System.Collections.Generic.IList<string>? scopes,
            int? expiresInSeconds)
        {
            this.Scopes = scopes;
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AuditLogApiKeyUpdatedChangesRequested" /> class.
        /// </summary>
        public AuditLogApiKeyUpdatedChangesRequested()
        {
        }

    }
}