
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Request payload for creating a custom role.
    /// </summary>
    public sealed partial class PublicCreateOrganizationRoleBody
    {
        /// <summary>
        /// Unique name for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("role_name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string RoleName { get; set; }

        /// <summary>
        /// Permissions to grant to the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// Optional description of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateOrganizationRoleBody" /> class.
        /// </summary>
        /// <param name="roleName">
        /// Unique name for the role.
        /// </param>
        /// <param name="permissions">
        /// Permissions to grant to the role.
        /// </param>
        /// <param name="description">
        /// Optional description of the role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicCreateOrganizationRoleBody(
            string roleName,
            global::System.Collections.Generic.IList<string> permissions,
            string? description)
        {
            this.RoleName = roleName ?? throw new global::System.ArgumentNullException(nameof(roleName));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.Description = description;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicCreateOrganizationRoleBody" /> class.
        /// </summary>
        public PublicCreateOrganizationRoleBody()
        {
        }
    }
}