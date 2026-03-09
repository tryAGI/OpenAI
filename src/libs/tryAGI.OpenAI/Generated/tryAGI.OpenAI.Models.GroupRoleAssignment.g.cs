
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Role assignment linking a group to a role.
    /// </summary>
    public sealed partial class GroupRoleAssignment
    {
        /// <summary>
        /// Always `group.role`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupRoleAssignmentObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupRoleAssignmentObject Object { get; set; }

        /// <summary>
        /// Summary information about a group returned in role assignment responses.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("group")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Group Group { get; set; }

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
        /// Initializes a new instance of the <see cref="GroupRoleAssignment" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `group.role`.
        /// </param>
        /// <param name="group">
        /// Summary information about a group returned in role assignment responses.
        /// </param>
        /// <param name="role">
        /// Details about a role that can be assigned through the public Roles API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupRoleAssignment(
            global::tryAGI.OpenAI.Group group,
            global::tryAGI.OpenAI.Role role,
            global::tryAGI.OpenAI.GroupRoleAssignmentObject @object)
        {
            this.Group = group ?? throw new global::System.ArgumentNullException(nameof(group));
            this.Role = role ?? throw new global::System.ArgumentNullException(nameof(role));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupRoleAssignment" /> class.
        /// </summary>
        public GroupRoleAssignment()
        {
        }
    }
}