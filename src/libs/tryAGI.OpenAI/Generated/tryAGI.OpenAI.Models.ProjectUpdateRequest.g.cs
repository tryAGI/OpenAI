
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectUpdateRequest
    {
        /// <summary>
        /// The updated name of the project, this name appears in reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// External key ID to associate with the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

        /// <summary>
        /// Geography for the project.<br/>
        /// Deprecated: use `residency` when creating a project to configure data residency. This field is retained for backward compatibility.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geography")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Geography { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The updated name of the project, this name appears in reports.
        /// </param>
        /// <param name="externalKeyId">
        /// External key ID to associate with the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectUpdateRequest(
            string? name,
            string? externalKeyId)
        {
            this.Name = name;
            this.ExternalKeyId = externalKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectUpdateRequest" /> class.
        /// </summary>
        public ProjectUpdateRequest()
        {
        }

    }
}