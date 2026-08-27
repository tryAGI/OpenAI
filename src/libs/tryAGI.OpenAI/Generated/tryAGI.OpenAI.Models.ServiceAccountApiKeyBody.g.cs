
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ServiceAccountApiKeyBody
    {
        /// <summary>
        /// The object type, which is always `organization.project.service_account.api_key`<br/>
        /// Default Value: organization.project.service_account.api_key
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject.OrganizationProjectServiceAccountApiKey</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ServiceAccountApiKeyBodyObjectJsonConverter))]
        public global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject Object { get; set; } = global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject.OrganizationProjectServiceAccountApiKey;

        /// <summary>
        /// The unredacted API key value.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// The name of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) when the API key was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The identifier of the API key.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountApiKeyBody" /> class.
        /// </summary>
        /// <param name="value">
        /// The unredacted API key value.
        /// </param>
        /// <param name="name">
        /// The name of the API key.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) when the API key was created.
        /// </param>
        /// <param name="id">
        /// The identifier of the API key.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.service_account.api_key`<br/>
        /// Default Value: organization.project.service_account.api_key
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ServiceAccountApiKeyBody(
            string value,
            string name,
            int createdAt,
            string id,
            global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject @object = global::tryAGI.OpenAI.ServiceAccountApiKeyBodyObject.OrganizationProjectServiceAccountApiKey)
        {
            this.Object = @object;
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAccountApiKeyBody" /> class.
        /// </summary>
        public ServiceAccountApiKeyBody()
        {
        }

    }
}