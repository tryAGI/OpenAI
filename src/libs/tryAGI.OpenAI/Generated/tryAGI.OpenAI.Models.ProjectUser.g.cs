
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual user in a project.
    /// </summary>
    public sealed partial class ProjectUser
    {
        /// <summary>
        /// The object type, which is always `organization.project.user`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectUserObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The name of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Role { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
        /// <param name="addedAt">
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.user`
        /// </param>
        /// <param name="name">
        /// The name of the user
        /// </param>
        /// <param name="email">
        /// The email address of the user
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUser(
            string id,
            string role,
            int addedAt,
            global::tryAGI.OpenAI.ProjectUserObject @object,
            string? name,
            string? email)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Email = email;
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.AddedAt = addedAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        public ProjectUser()
        {
        }
    }
}