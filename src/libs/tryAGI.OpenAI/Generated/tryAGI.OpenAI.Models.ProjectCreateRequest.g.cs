
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ProjectCreateRequest
    {
        /// <summary>
        /// The friendly name of the project, this name appears in reports.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Name { get; set; }

        /// <summary>
        /// Create the project with the specified data residency region. Your organization must have access to Data residency functionality in order to use. See [data residency controls](https://developers.openai.com/api/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.<br/>
        /// Deprecated: use `residency` instead. Do not provide both `geography` and `residency`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geography")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public string? Geography { get; set; }

        /// <summary>
        /// Create the project with the specified residency configuration. Your organization must have access to the requested residency configuration in order to use it. See [data residency controls](https://developers.openai.com/api/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("residency")]
        public global::tryAGI.OpenAI.PublicProjectResidency? Residency { get; set; }

        /// <summary>
        /// External key ID to associate with the project.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("external_key_id")]
        public string? ExternalKeyId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The friendly name of the project, this name appears in reports.
        /// </param>
        /// <param name="residency">
        /// Create the project with the specified residency configuration. Your organization must have access to the requested residency configuration in order to use it. See [data residency controls](https://developers.openai.com/api/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
        /// </param>
        /// <param name="externalKeyId">
        /// External key ID to associate with the project.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreateRequest(
            string name,
            global::tryAGI.OpenAI.PublicProjectResidency? residency,
            string? externalKeyId)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Residency = residency;
            this.ExternalKeyId = externalKeyId;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequest" /> class.
        /// </summary>
        public ProjectCreateRequest()
        {
        }

    }
}