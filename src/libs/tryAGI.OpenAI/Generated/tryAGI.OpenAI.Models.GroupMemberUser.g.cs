
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about a user returned from an organization group membership lookup.
    /// </summary>
    public sealed partial class GroupMemberUser
    {
        /// <summary>
        /// Identifier for the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Display name of the user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Email address of the user, or `null` for users without an email.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("email")]
        public string? Email { get; set; }

        /// <summary>
        /// URL of the user's profile picture, if available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("picture")]
        public string? Picture { get; set; }

        /// <summary>
        /// Whether the user is a service account.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("is_service_account")]
        public bool? IsServiceAccount { get; set; }

        /// <summary>
        /// The type of user.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user_type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupMemberUserUserTypeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.GroupMemberUserUserType UserType { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberUser" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the user.
        /// </param>
        /// <param name="name">
        /// Display name of the user.
        /// </param>
        /// <param name="userType">
        /// The type of user.
        /// </param>
        /// <param name="email">
        /// Email address of the user, or `null` for users without an email.
        /// </param>
        /// <param name="picture">
        /// URL of the user's profile picture, if available.
        /// </param>
        /// <param name="isServiceAccount">
        /// Whether the user is a service account.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupMemberUser(
            string id,
            string name,
            global::tryAGI.OpenAI.GroupMemberUserUserType userType,
            string? email,
            string? picture,
            bool? isServiceAccount)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Email = email;
            this.Picture = picture;
            this.IsServiceAccount = isServiceAccount;
            this.UserType = userType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupMemberUser" /> class.
        /// </summary>
        public GroupMemberUser()
        {
        }

    }
}