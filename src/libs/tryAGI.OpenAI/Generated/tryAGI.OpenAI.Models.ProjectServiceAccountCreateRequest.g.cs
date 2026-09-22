
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectServiceAccountCreateRequest
    {
        /// <summary>
        /// The name of the service account being created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("create_service_account_only")]
        public bool? CreateServiceAccountOnly { get; set; }

        /// <summary>
        /// Number of seconds until the initial API key expires. If omitted or null, the key does not expire unless the effective organization or project policy requires an expiration. When a policy sets a maximum lifetime, this value must be provided and must not exceed that limit. A non-null value cannot be used when `create_service_account_only` is true.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_in_seconds")]
        public int? ExpiresInSeconds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the service account being created.
        /// </param>
        /// <param name="createServiceAccountOnly"></param>
        /// <param name="expiresInSeconds">
        /// Number of seconds until the initial API key expires. If omitted or null, the key does not expire unless the effective organization or project policy requires an expiration. When a policy sets a maximum lifetime, this value must be provided and must not exceed that limit. A non-null value cannot be used when `create_service_account_only` is true.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectServiceAccountCreateRequest(
            string name,
            bool? createServiceAccountOnly,
            int? expiresInSeconds)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreateServiceAccountOnly = createServiceAccountOnly;
            this.ExpiresInSeconds = expiresInSeconds;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountCreateRequest" /> class.
        /// </summary>
        public ProjectServiceAccountCreateRequest()
        {
        }

    }
}