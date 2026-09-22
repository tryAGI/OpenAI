
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ExternalStorageResponse
    {
        /// <summary>
        /// Default Value: organization.external_storage
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ExternalStorageResponseObject.OrganizationExternalStorage</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalStorageResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.ExternalStorageResponseObject Object { get; set; } = global::tryAGI.OpenAI.ExternalStorageResponseObject.OrganizationExternalStorage;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("project_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ProjectId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("provider")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.Provider2JsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.Provider2 Provider { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("geography")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Geography { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ExternalStorageStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ExternalStorageStatus Status { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int CreatedAt { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorageResponse" /> class.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="projectId"></param>
        /// <param name="provider"></param>
        /// <param name="geography"></param>
        /// <param name="status"></param>
        /// <param name="createdAt"></param>
        /// <param name="object">
        /// Default Value: organization.external_storage
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ExternalStorageResponse(
            string id,
            string projectId,
            global::tryAGI.OpenAI.Provider2 provider,
            string geography,
            global::tryAGI.OpenAI.ExternalStorageStatus status,
            int createdAt,
            global::tryAGI.OpenAI.ExternalStorageResponseObject @object = global::tryAGI.OpenAI.ExternalStorageResponseObject.OrganizationExternalStorage)
        {
            this.Object = @object;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.ProjectId = projectId ?? throw new global::System.ArgumentNullException(nameof(projectId));
            this.Provider = provider;
            this.Geography = geography ?? throw new global::System.ArgumentNullException(nameof(geography));
            this.Status = status;
            this.CreatedAt = createdAt;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ExternalStorageResponse" /> class.
        /// </summary>
        public ExternalStorageResponse()
        {
        }

    }
}