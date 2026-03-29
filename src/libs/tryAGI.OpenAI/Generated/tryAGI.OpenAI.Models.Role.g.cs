
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Details about a role that can be assigned through the public Roles API.
    /// </summary>
    public sealed partial class Role
    {
        /// <summary>
        /// Always `role`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.RoleObjectJsonConverter))]
        public global::tryAGI.OpenAI.RoleObject Object { get; set; }

        /// <summary>
        /// Identifier for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Unique name for the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Optional description of the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("description")]
        public string? Description { get; set; }

        /// <summary>
        /// Permissions granted by the role.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("permissions")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Permissions { get; set; }

        /// <summary>
        /// Resource type the role is bound to (for example `api.organization` or `api.project`).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("resource_type")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ResourceType { get; set; }

        /// <summary>
        /// Whether the role is predefined and managed by OpenAI.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("predefined_role")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool PredefinedRole { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        /// <param name="id">
        /// Identifier for the role.
        /// </param>
        /// <param name="name">
        /// Unique name for the role.
        /// </param>
        /// <param name="permissions">
        /// Permissions granted by the role.
        /// </param>
        /// <param name="resourceType">
        /// Resource type the role is bound to (for example `api.organization` or `api.project`).
        /// </param>
        /// <param name="predefinedRole">
        /// Whether the role is predefined and managed by OpenAI.
        /// </param>
        /// <param name="object">
        /// Always `role`.
        /// </param>
        /// <param name="description">
        /// Optional description of the role.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Role(
            string id,
            string name,
            global::System.Collections.Generic.IList<string> permissions,
            string resourceType,
            bool predefinedRole,
            global::tryAGI.OpenAI.RoleObject @object,
            string? description)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Description = description;
            this.Permissions = permissions ?? throw new global::System.ArgumentNullException(nameof(permissions));
            this.ResourceType = resourceType ?? throw new global::System.ArgumentNullException(nameof(resourceType));
            this.PredefinedRole = predefinedRole;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Role" /> class.
        /// </summary>
        public Role()
        {
        }
    }
}