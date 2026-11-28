
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Confirmation payload returned after deleting project model permissions.
    /// </summary>
    public sealed partial class ProjectModelPermissionsDeleteResponse
    {
        /// <summary>
        /// The object type, which is always `project.model_permissions.deleted`.
        /// </summary>
        /// <default>"project.model_permissions.deleted"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "project.model_permissions.deleted";

        /// <summary>
        /// Whether the project model permissions were deleted.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("deleted")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool Deleted { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModelPermissionsDeleteResponse" /> class.
        /// </summary>
        /// <param name="deleted">
        /// Whether the project model permissions were deleted.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `project.model_permissions.deleted`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectModelPermissionsDeleteResponse(
            bool deleted,
            string @object = "project.model_permissions.deleted")
        {
            this.Object = @object;
            this.Deleted = deleted;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModelPermissionsDeleteResponse" /> class.
        /// </summary>
        public ProjectModelPermissionsDeleteResponse()
        {
        }

        /// <summary>
        /// Creates a new <see cref="ProjectModelPermissionsDeleteResponse"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static ProjectModelPermissionsDeleteResponse FromDeleted(bool deleted)
        {
            return new ProjectModelPermissionsDeleteResponse
            {
                Deleted = deleted,
            };
        }

    }
}