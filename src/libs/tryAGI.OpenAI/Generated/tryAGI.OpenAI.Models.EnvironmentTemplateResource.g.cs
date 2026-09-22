
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Reusable configuration that provisions a fresh OpenAI-hosted environment for each session.
    /// </summary>
    public sealed partial class EnvironmentTemplateResource
    {
        /// <summary>
        /// The ID of the reusable environment template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// An optional human-readable display name for the template.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// The object type. Always `agent.environment.template`.<br/>
        /// Default Value: agent.environment.template
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentTemplateResourceObject.AgentEnvironmentTemplate</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentTemplateResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentTemplateResourceObject Object { get; set; } = global::tryAGI.OpenAI.EnvironmentTemplateResourceObject.AgentEnvironmentTemplate;

        /// <summary>
        /// The Unix timestamp, in seconds, when the template was created.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset CreatedAt { get; set; }

        /// <summary>
        /// The Unix timestamp, in seconds, when the template was last updated.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("updated_at")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.DateTimeOffset UpdatedAt { get; set; }

        /// <summary>
        /// Packages installed in each fresh OpenAI-hosted environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("packages")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentPackagesResource Packages { get; set; }

        /// <summary>
        /// Runtime network access for each OpenAI-hosted environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.NetworkPolicyResource Network { get; set; }

        /// <summary>
        /// Directories that expose capabilities to the agent.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("capability_directories")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> CapabilityDirectories { get; set; }

        /// <summary>
        /// Safe skill metadata, preserving unresolved version selectors.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource> Skills { get; set; }

        /// <summary>
        /// Safe plugin metadata, excluding inline archive contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> Plugins { get; set; }

        /// <summary>
        /// Safe file metadata, excluding contents and session-scoped file IDs.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTemplateResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the reusable environment template.
        /// </param>
        /// <param name="createdAt">
        /// The Unix timestamp, in seconds, when the template was created.
        /// </param>
        /// <param name="updatedAt">
        /// The Unix timestamp, in seconds, when the template was last updated.
        /// </param>
        /// <param name="packages">
        /// Packages installed in each fresh OpenAI-hosted environment.
        /// </param>
        /// <param name="network">
        /// Runtime network access for each OpenAI-hosted environment.
        /// </param>
        /// <param name="capabilityDirectories">
        /// Directories that expose capabilities to the agent.
        /// </param>
        /// <param name="skills">
        /// Safe skill metadata, preserving unresolved version selectors.
        /// </param>
        /// <param name="plugins">
        /// Safe plugin metadata, excluding inline archive contents.
        /// </param>
        /// <param name="files">
        /// Safe file metadata, excluding contents and session-scoped file IDs.
        /// </param>
        /// <param name="name">
        /// An optional human-readable display name for the template.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.environment.template`.<br/>
        /// Default Value: agent.environment.template
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentTemplateResource(
            string id,
            global::System.DateTimeOffset createdAt,
            global::System.DateTimeOffset updatedAt,
            global::tryAGI.OpenAI.EnvironmentPackagesResource packages,
            global::tryAGI.OpenAI.NetworkPolicyResource network,
            global::System.Collections.Generic.IList<string> capabilityDirectories,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateSkillResource> skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedTemplateFileResource> files,
            string? name,
            global::tryAGI.OpenAI.EnvironmentTemplateResourceObject @object = global::tryAGI.OpenAI.EnvironmentTemplateResourceObject.AgentEnvironmentTemplate)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Name = name;
            this.Object = @object;
            this.CreatedAt = createdAt;
            this.UpdatedAt = updatedAt;
            this.Packages = packages ?? throw new global::System.ArgumentNullException(nameof(packages));
            this.Network = network ?? throw new global::System.ArgumentNullException(nameof(network));
            this.CapabilityDirectories = capabilityDirectories ?? throw new global::System.ArgumentNullException(nameof(capabilityDirectories));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
            this.Plugins = plugins ?? throw new global::System.ArgumentNullException(nameof(plugins));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentTemplateResource" /> class.
        /// </summary>
        public EnvironmentTemplateResource()
        {
        }

    }
}