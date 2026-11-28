
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Role assignment linking a user to a role.
    /// </summary>
    public sealed partial class UserRoleAssignment
    {
        /// <summary>
        /// Always `user.role`.
        /// </summary>
        /// <default>"user.role"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "user.role";

        /// <summary>
        /// Represents an individual `user` within an organization.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("user")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.User User { get; set; }

        /// <summary>
        /// Details about a role that can be assigned through the public Roles API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Role Role { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleAssignment" /> class.
        /// </summary>
        /// <param name="user">
        /// Represents an individual `user` within an organization.
        /// </param>
        /// <param name="role">
        /// Details about a role that can be assigned through the public Roles API.
        /// </param>
        /// <param name="object">
        /// Always `user.role`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRoleAssignment(
            global::tryAGI.OpenAI.User user,
            global::tryAGI.OpenAI.Role role,
            string @object = "user.role")
        {
            this.Object = @object;
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleAssignment" /> class.
        /// </summary>
        public UserRoleAssignment()
        {
        }

    }
}