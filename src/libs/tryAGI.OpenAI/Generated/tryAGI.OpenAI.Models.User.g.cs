
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual `user` within an organization.
    /// </summary>
    public sealed partial class User
    {
        /// <summary>
        /// The object type, which is always `organization.user`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserObjectJsonConverter))]
        public global::tryAGI.OpenAI.UserObject Object { get; set; }

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
        /// `owner` or `reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        public string? Role { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the user was added.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("added_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int AddedAt { get; set; }

        /// <summary>
        /// Whether this is the organization's default user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_default")]
        public bool? IsDefault { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the user was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created")]
        public int? Created { get; set; }

        /// <summary>
        /// Nested user details.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        public global::tryAGI.OpenAI.UserUser1? User1 { get; set; }

        /// <summary>
        /// Whether the user is a service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_service_account")]
        public bool? IsServiceAccount { get; set; }

        /// <summary>
        /// Whether the user is an authorized purchaser for Scale Tier.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scale_tier_authorized_purchaser")]
        public bool? IsScaleTierAuthorizedPurchaser { get; set; }

        /// <summary>
        /// Whether the user is managed through SCIM.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_scim_managed")]
        public bool? IsScimManaged { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of the user's last API key usage.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("api_key_last_used_at")]
        public int? ApiKeyLastUsedAt { get; set; }

        /// <summary>
        /// The technical level metadata for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("technical_level")]
        public string? TechnicalLevel { get; set; }

        /// <summary>
        /// The developer persona metadata for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("developer_persona")]
        public string? DeveloperPersona { get; set; }

        /// <summary>
        /// Projects associated with the user, if included.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::tryAGI.OpenAI.UserProjects2? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="addedAt">
        /// The Unix timestamp (in seconds) of when the user was added.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.user`
        /// </param>
        /// <param name="name">
        /// The name of the user
        /// </param>
        /// <param name="email">
        /// The email address of the user
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="isDefault">
        /// Whether this is the organization's default user.
        /// </param>
        /// <param name="created">
        /// The Unix timestamp (in seconds) of when the user was created.
        /// </param>
        /// <param name="user1">
        /// Nested user details.
        /// </param>
        /// <param name="isServiceAccount">
        /// Whether the user is a service account.
        /// </param>
        /// <param name="isScaleTierAuthorizedPurchaser">
        /// Whether the user is an authorized purchaser for Scale Tier.
        /// </param>
        /// <param name="isScimManaged">
        /// Whether the user is managed through SCIM.
        /// </param>
        /// <param name="apiKeyLastUsedAt">
        /// The Unix timestamp (in seconds) of the user's last API key usage.
        /// </param>
        /// <param name="technicalLevel">
        /// The technical level metadata for the user.
        /// </param>
        /// <param name="developerPersona">
        /// The developer persona metadata for the user.
        /// </param>
        /// <param name="projects">
        /// Projects associated with the user, if included.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public User(
            string id,
            int addedAt,
            global::tryAGI.OpenAI.UserObject @object,
            string? name,
            string? email,
            string? role,
            bool? isDefault,
            int? created,
            global::tryAGI.OpenAI.UserUser1? user1,
            bool? isServiceAccount,
            bool? isScaleTierAuthorizedPurchaser,
            bool? isScimManaged,
            int? apiKeyLastUsedAt,
            string? technicalLevel,
            string? developerPersona,
            global::tryAGI.OpenAI.UserProjects2? projects)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Email = email;
            this.Role = role;
            this.AddedAt = addedAt;
            this.IsDefault = isDefault;
            this.Created = created;
            this.User1 = user1;
            this.IsServiceAccount = isServiceAccount;
            this.IsScaleTierAuthorizedPurchaser = isScaleTierAuthorizedPurchaser;
            this.IsScimManaged = isScimManaged;
            this.ApiKeyLastUsedAt = apiKeyLastUsedAt;
            this.TechnicalLevel = technicalLevel;
            this.DeveloperPersona = developerPersona;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="User" /> class.
        /// </summary>
        public User()
        {
        }
    }
}