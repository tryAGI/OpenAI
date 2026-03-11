
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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserRoleAssignmentObjectJsonConverter))]
        public global::tryAGI.OpenAI.UserRoleAssignmentObject Object { get; set; }

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
        /// <param name="object">
        /// Always `user.role`.
        /// </param>
        /// <param name="user">
        /// Represents an individual `user` within an organization.
        /// </param>
        /// <param name="role">
        /// Details about a role that can be assigned through the public Roles API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserRoleAssignment(
            global::tryAGI.OpenAI.User user,
            global::tryAGI.OpenAI.Role role,
            global::tryAGI.OpenAI.UserRoleAssignmentObject @object)
        {
            this.User = user ?? throw new global::System.ArgumentNullException(nameof(user));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserRoleAssignment" /> class.
        /// </summary>
        public UserRoleAssignment()
        {
        }
    }
}