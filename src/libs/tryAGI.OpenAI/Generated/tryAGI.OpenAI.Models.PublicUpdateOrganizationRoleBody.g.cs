
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for updating an existing role.
    /// </summary>
    public sealed partial class PublicUpdateOrganizationRoleBody
    {
        /// <summary>
        /// Updated set of permissions for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        public global::System.Collections.Generic.IList<string>? Permissions { get; set; }

        /// <summary>
        /// New description for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// New name for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        public string? RoleName { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUpdateOrganizationRoleBody" /> class.
        /// </summary>
        /// <param name="permissions">
        /// Updated set of permissions for the role.
        /// </param>
        /// <param name="description">
        /// New description for the role.
        /// </param>
        /// <param name="roleName">
        /// New name for the role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicUpdateOrganizationRoleBody(
            global::System.Collections.Generic.IList<string>? permissions,
            string? description,
            string? roleName)
        {
            this.Permissions = permissions;
            this.Description = description;
            this.RoleName = roleName;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicUpdateOrganizationRoleBody" /> class.
        /// </summary>
        public PublicUpdateOrganizationRoleBody()
        {
        }
    }
}