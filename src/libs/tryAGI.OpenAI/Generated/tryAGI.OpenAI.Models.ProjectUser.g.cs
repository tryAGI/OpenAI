
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual user in a project.
    /// </summary>
    public sealed partial class ProjectUser
    {
        /// <summary>
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset AddedAt { get; set; }

        /// <summary>
        /// The email address of the user
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

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
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// The object type, which is always `organization.project.user`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectUserObject Object { get; set; }

        /// <summary>
        /// `owner` or `member`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectUserRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProjectUserRole Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        /// <param name="addedAt">
        /// The Unix timestamp (in seconds) of when the project was added.
        /// </param>
        /// <param name="email">
        /// The email address of the user
        /// </param>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="name">
        /// The name of the user
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.project.user`
        /// </param>
        /// <param name="role">
        /// `owner` or `member`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUser(
            global::System.DateTimeOffset addedAt,
            string email,
            string id,
            string name,
            global::tryAGI.OpenAI.ProjectUserRole role,
            global::tryAGI.OpenAI.ProjectUserObject @object)
        {
            this.AddedAt = addedAt;
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Role = role;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUser" /> class.
        /// </summary>
        public ProjectUser()
        {
        }
    }
}