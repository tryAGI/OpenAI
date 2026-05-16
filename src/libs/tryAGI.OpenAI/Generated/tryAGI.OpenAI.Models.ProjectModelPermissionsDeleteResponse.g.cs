
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
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsDeleteResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject Object { get; set; }

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
            global::tryAGI.OpenAI.ProjectModelPermissionsDeleteResponseObject @object)
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

    }
}