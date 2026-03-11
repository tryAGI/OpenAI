
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for assigning a role to a group or user.
    /// </summary>
    public sealed partial class PublicAssignOrganizationGroupRoleBody
    {
        /// <summary>
        /// Identifier of the role to assign.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string RoleId { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssignOrganizationGroupRoleBody" /> class.
        /// </summary>
        /// <param name="roleId">
        /// Identifier of the role to assign.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicAssignOrganizationGroupRoleBody(
            string roleId)
        {
            this.RoleId = roleId ?? throw new global::System.ArgumentNullException(nameof(roleId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicAssignOrganizationGroupRoleBody" /> class.
        /// </summary>
        public PublicAssignOrganizationGroupRoleBody()
        {
        }
    }
}