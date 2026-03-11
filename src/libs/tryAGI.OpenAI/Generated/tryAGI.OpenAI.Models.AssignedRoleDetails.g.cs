
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Detailed information about a role assignment entry returned when listing assignments.
    /// </summary>
    public sealed partial class AssignedRoleDetails
    {
        /// <summary>
        /// Identifier for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Name of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// Permissions associated with the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<string> Permissions { get; set; } = default!;

        /// <summary>
        /// Resource type the role applies to.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string ResourceType { get; set; } = default!;

        /// <summary>
        /// Whether the role is predefined by OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool PredefinedRole { get; set; } = default!;

        /// <summary>
        /// Description of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// When the role was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        public long? CreatedAt { get; set; }

        /// <summary>
        /// When the role was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        public long? UpdatedAt { get; set; }

        /// <summary>
        /// Identifier of the actor who created the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by")]
        public string? CreatedBy { get; set; }

        /// <summary>
        /// User details for the actor that created the role, when available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_by_user_obj")]
        public object? CreatedByUserObj { get; set; }

        /// <summary>
        /// Arbitrary metadata stored on the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedRoleDetails" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the role.
        /// </param>
        /// <param name="name">
        /// Name of the role.
        /// </param>
        /// <param name="permissions">
        /// Permissions associated with the role.
        /// </param>
        /// <param name="resourceType">
        /// Resource type the role applies to.
        /// </param>
        /// <param name="predefinedRole">
        /// Whether the role is predefined by OpenAI.
        /// </param>
        /// <param name="description">
        /// Description of the role.
        /// </param>
        /// <param name="createdAt">
        /// When the role was created.
        /// </param>
        /// <param name="updatedAt">
        /// When the role was last updated.
        /// </param>
        /// <param name="createdBy">
        /// Identifier of the actor who created the role.
        /// </param>
        /// <param name="createdByUserObj">
        /// User details for the actor that created the role, when available.
        /// </param>
        /// <param name="metadata">
        /// Arbitrary metadata stored on the role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public AssignedRoleDetails(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            string resourceType,
            bool predefinedRole,
            string? description,
            long? createdAt,
            long? updatedAt,
            string? createdBy,
            object? createdByUserObj,
            object? metadata)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.PredefinedRole = predefinedRole;
            this.Description = description;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.CreatedBy = createdBy;
            this.CreatedByUserObj = createdByUserObj;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AssignedRoleDetails" /> class.
        /// </summary>
        public AssignedRoleDetails()
        {
        }
    }
}