
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Safe metadata for a first-class execution environment.
    /// </summary>
    public sealed partial class PublicEnvironmentResource
    {
        /// <summary>
        /// The ID of the environment.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The object type. Always `agent.environment`.<br/>
        /// Default Value: agent.environment
        /// </summary>
        /// <default>global::tryAGI.OpenAI.PublicEnvironmentResourceObject.AgentEnvironment</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PublicEnvironmentResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.PublicEnvironmentResourceObject Object { get; set; } = global::tryAGI.OpenAI.PublicEnvironmentResourceObject.AgentEnvironment;

        /// <summary>
        /// Whether the environment is hosted by OpenAI or by the application.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentTypeResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentTypeResource Type { get; set; }

        /// <summary>
        /// The current environment connection status.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentStatusResourceJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.EnvironmentStatusResource Status { get; set; }

        /// <summary>
        /// Plugins installed in the environment, without their archive contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("plugins")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> Plugins { get; set; }

        /// <summary>
        /// Skills installed in the environment, without their archive contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource> Skills { get; set; }

        /// <summary>
        /// Files installed in the environment, without their contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("files")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource> Files { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEnvironmentResource" /> class.
        /// </summary>
        /// <param name="id">
        /// The ID of the environment.
        /// </param>
        /// <param name="type">
        /// Whether the environment is hosted by OpenAI or by the application.
        /// </param>
        /// <param name="status">
        /// The current environment connection status.
        /// </param>
        /// <param name="plugins">
        /// Plugins installed in the environment, without their archive contents.
        /// </param>
        /// <param name="skills">
        /// Skills installed in the environment, without their archive contents.
        /// </param>
        /// <param name="files">
        /// Files installed in the environment, without their contents.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.environment`.<br/>
        /// Default Value: agent.environment
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicEnvironmentResource(
            string id,
            global::tryAGI.OpenAI.EnvironmentTypeResource type,
            global::tryAGI.OpenAI.EnvironmentStatusResource status,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedPluginResource> plugins,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedSkillResource> skills,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.HostedEnvironmentFileResource> files,
            global::tryAGI.OpenAI.PublicEnvironmentResourceObject @object = global::tryAGI.OpenAI.PublicEnvironmentResourceObject.AgentEnvironment)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Object = @object;
            this.Type = type;
            this.Status = status;
            this.Plugins = plugins ?? throw new global::System.ArgumentNullException(nameof(plugins));
            this.Skills = skills ?? throw new global::System.ArgumentNullException(nameof(skills));
            this.Files = files ?? throw new global::System.ArgumentNullException(nameof(files));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicEnvironmentResource" /> class.
        /// </summary>
        public PublicEnvironmentResource()
        {
        }

    }
}