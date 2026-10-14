
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class UpdateProjectApiKeyBody
    {
        /// <summary>
        /// Number of seconds from this request until the API key expires. Must comply with the organization and project expiry policies. Expired keys cannot be updated. Retrying resets the expiry relative to the new request. Omit to keep the current expiration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Replace the API key scope restrictions. Omit to leave scopes unchanged. An empty array removes key restrictions (All permissions), subject to the owner's effective permissions. Use ["api.all.read"] for read-only access. Scopes do not change the owner's roles or grant administrative permissions.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("scopes")]
        public global::System.Collections.Generic.IList<string>? Scopes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectApiKeyBody" /> class.
        /// </summary>
        /// <param name="expiresInSeconds">
        /// Number of seconds from this request until the API key expires. Must comply with the organization and project expiry policies. Expired keys cannot be updated. Retrying resets the expiry relative to the new request. Omit to keep the current expiration.
        /// </param>
        /// <param name="scopes">
        /// Replace the API key scope restrictions. Omit to leave scopes unchanged. An empty array removes key restrictions (All permissions), subject to the owner's effective permissions. Use ["api.all.read"] for read-only access. Scopes do not change the owner's roles or grant administrative permissions.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateProjectApiKeyBody(
            int? expiresInSeconds,
            global::System.Collections.Generic.IList<string>? scopes)
        {
            this.ExpiresInSeconds = expiresInSeconds;
            this.Scopes = scopes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateProjectApiKeyBody" /> class.
        /// </summary>
        public UpdateProjectApiKeyBody()
        {
        }

    }
}