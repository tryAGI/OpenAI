
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectServiceAccountApiKey
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The object type, which is always `organization.project.service_account.api_key`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectServiceAccountApiKeyObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject Object { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("value")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Value { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountApiKey" /> class.
        /// </summary>
        /// <param name="createdAt"></param>
        /// <param name="id"></param>
        /// <param name="name"></param>
        /// <param name="object">
        /// The object type, which is always `organization.project.service_account.api_key`
        /// </param>
        /// <param name="value"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectServiceAccountApiKey(
            int createdAt,
            string id,
            string name,
            string value,
            global::tryAGI.OpenAI.ProjectServiceAccountApiKeyObject @object)
        {
            this.CreatedAt = createdAt;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Value = value ?? throw new global::System.ArgumentNullException(nameof(value));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectServiceAccountApiKey" /> class.
        /// </summary>
        public ProjectServiceAccountApiKey()
        {
        }
    }
}