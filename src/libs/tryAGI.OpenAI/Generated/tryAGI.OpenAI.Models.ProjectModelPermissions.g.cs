
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents the model allowlist or denylist policy for a project.
    /// </summary>
    public sealed partial class ProjectModelPermissions
    {
        /// <summary>
        /// The object type, which is always `project.model_permissions`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectModelPermissionsObject Object { get; set; }

        /// <summary>
        /// Whether the project uses an allowlist or a denylist.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProjectModelPermissionsMode Mode { get; set; }

        /// <summary>
        /// The model IDs included in the model permissions policy.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model_ids")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> ModelIds { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModelPermissions" /> class.
        /// </summary>
        /// <param name="mode">
        /// Whether the project uses an allowlist or a denylist.
        /// </param>
        /// <param name="modelIds">
        /// The model IDs included in the model permissions policy.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `project.model_permissions`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectModelPermissions(
            global::tryAGI.OpenAI.ProjectModelPermissionsMode mode,
            global::System.Collections.Generic.IList<string> modelIds,
            global::tryAGI.OpenAI.ProjectModelPermissionsObject @object)
        {
            this.Object = @object;
            this.Mode = mode;
            this.ModelIds = modelIds ?? throw new global::System.ArgumentNullException(nameof(modelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModelPermissions" /> class.
        /// </summary>
        public ProjectModelPermissions()
        {
        }

    }
}