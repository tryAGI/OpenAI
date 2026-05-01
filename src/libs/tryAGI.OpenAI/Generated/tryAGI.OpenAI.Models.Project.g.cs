
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual project.
    /// </summary>
    public sealed partial class Project
    {
        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type, which is always `organization.project`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectObject Object { get; set; }

        /// <summary>
        /// The name of the project. This appears in reporting.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("archived_at")]
        public int? ArchivedAt { get; set; }

        /// <summary>
        /// `active` or `archived`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        public string? Status { get; set; }

        /// <summary>
        /// The external key associated with the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the project was created.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project`
        /// </param>
        /// <param name="name">
        /// The name of the project. This appears in reporting.
        /// </param>
        /// <param name="archivedAt"></param>
        /// <param name="status">
        /// `active` or `archived`
        /// </param>
        /// <param name="externalKeyId">
        /// The external key associated with the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Project(
            string id,
            int createdAt,
            global::tryAGI.OpenAI.ProjectObject @object,
            string? name,
            int? archivedAt,
            string? status,
            string? externalKeyId)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Name = name;
            this.CreatedAt = createdAt;
            this.ArchivedAt = archivedAt;
            this.Status = status;
            this.ExternalKeyId = externalKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Project" /> class.
        /// </summary>
        public Project()
        {
        }
    }
}