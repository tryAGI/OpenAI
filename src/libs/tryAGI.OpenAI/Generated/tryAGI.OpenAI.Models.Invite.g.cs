
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an individual `invite` to the organization.
    /// </summary>
    public sealed partial class Invite
    {
        /// <summary>
        /// The object type, which is always `organization.invite`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteObjectJsonConverter))]
        public global::tryAGI.OpenAI.InviteObject Object { get; set; }

        /// <summary>
        /// The identifier, which can be referenced in API endpoints
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The email address of the individual to whom the invite was sent
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Email { get; set; }

        /// <summary>
        /// `owner` or `reader`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteRoleJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InviteRole Role { get; set; }

        /// <summary>
        /// `accepted`,`expired`, or `pending`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.InviteStatus Status { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_at")]
        public int? ExpiresAt { get; set; }

        /// <summary>
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("accepted_at")]
        public int? AcceptedAt { get; set; }

        /// <summary>
        /// The projects that were granted membership upon acceptance of the invite.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("projects")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? Projects { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        /// <param name="id">
        /// The identifier, which can be referenced in API endpoints
        /// </param>
        /// <param name="email">
        /// The email address of the individual to whom the invite was sent
        /// </param>
        /// <param name="role">
        /// `owner` or `reader`
        /// </param>
        /// <param name="status">
        /// `accepted`,`expired`, or `pending`
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp (in seconds) of when the invite was sent.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `organization.invite`
        /// </param>
        /// <param name="expiresAt">
        /// The Unix timestamp (in seconds) of when the invite expires.
        /// </param>
        /// <param name="acceptedAt">
        /// The Unix timestamp (in seconds) of when the invite was accepted.
        /// </param>
        /// <param name="projects">
        /// The projects that were granted membership upon acceptance of the invite.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Invite(
            string id,
            string email,
            global::tryAGI.OpenAI.InviteRole role,
            global::tryAGI.OpenAI.InviteStatus status,
            int createdAt,
            global::tryAGI.OpenAI.InviteObject @object,
            int? expiresAt,
            int? acceptedAt,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InviteProject>? projects)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Email = email ?? throw new global::System.ArgumentNullException(nameof(email));
            this.Role = role;
            this.Status = status;
            this.CreatedAt = createdAt;
            this.ExpiresAt = expiresAt;
            this.AcceptedAt = acceptedAt;
            this.Projects = projects;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Invite" /> class.
        /// </summary>
        public Invite()
        {
        }
    }
}