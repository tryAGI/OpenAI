
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
        /// Create the project with the specified data residency region. Your organization must have access to Data residency functionality in order to use. See [data residency controls](/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geography")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectCreateRequestGeographyJsonConverter))]
        public global::tryAGI.OpenAI.ProjectCreateRequestGeography? Geography { get; set; }

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
        /// <param name="geography">
        /// Create the project with the specified data residency region. Your organization must have access to Data residency functionality in order to use. See [data residency controls](/docs/guides/your-data#data-residency-controls) to review the functionality and limitations of setting this field.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectCreateRequest(
            string name,
            global::tryAGI.OpenAI.ProjectCreateRequestGeography? geography)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.Geography = geography;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectCreateRequest" /> class.
        /// </summary>
        public ProjectCreateRequest()
        {
        }
    }
}