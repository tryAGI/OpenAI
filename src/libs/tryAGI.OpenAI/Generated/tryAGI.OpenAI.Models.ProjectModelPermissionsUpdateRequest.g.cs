
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ProjectModelPermissionsUpdateRequest
    {
        /// <summary>
        /// The model permissions mode to apply.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("mode")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectModelPermissionsUpdateRequestModeJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode Mode { get; set; }

        /// <summary>
        /// The model IDs included in this permissions policy.
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
        /// Initializes a new instance of the <see cref="ProjectModelPermissionsUpdateRequest" /> class.
        /// </summary>
        /// <param name="mode">
        /// The model permissions mode to apply.
        /// </param>
        /// <param name="modelIds">
        /// The model IDs included in this permissions policy.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectModelPermissionsUpdateRequest(
            global::tryAGI.OpenAI.ProjectModelPermissionsUpdateRequestMode mode,
            global::System.Collections.Generic.IList<string> modelIds)
        {
            this.Mode = mode;
            this.ModelIds = modelIds ?? throw new global::System.ArgumentNullException(nameof(modelIds));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectModelPermissionsUpdateRequest" /> class.
        /// </summary>
        public ProjectModelPermissionsUpdateRequest()
        {
        }

    }
}