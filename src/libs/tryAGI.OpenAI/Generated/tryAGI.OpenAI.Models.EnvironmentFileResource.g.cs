
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A live file in an execution environment.
    /// </summary>
    public sealed partial class EnvironmentFileResource
    {
        /// <summary>
        /// The object type. Always `agent.environment.file`.<br/>
        /// Default Value: agent.environment.file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EnvironmentFileResourceObject.AgentEnvironmentFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EnvironmentFileResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.EnvironmentFileResourceObject Object { get; set; } = global::tryAGI.OpenAI.EnvironmentFileResourceObject.AgentEnvironmentFile;

        /// <summary>
        /// The ID of the environment containing this file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("environment_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string EnvironmentId { get; set; }

        /// <summary>
        /// The absolute file path inside the environment's workspace.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("path")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Path { get; set; }

        /// <summary>
        /// The file size in bytes.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("size_bytes")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required long SizeBytes { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFileResource" /> class.
        /// </summary>
        /// <param name="environmentId">
        /// The ID of the environment containing this file.
        /// </param>
        /// <param name="path">
        /// The absolute file path inside the environment's workspace.
        /// </param>
        /// <param name="sizeBytes">
        /// The file size in bytes.
        /// </param>
        /// <param name="object">
        /// The object type. Always `agent.environment.file`.<br/>
        /// Default Value: agent.environment.file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EnvironmentFileResource(
            string environmentId,
            string path,
            long sizeBytes,
            global::tryAGI.OpenAI.EnvironmentFileResourceObject @object = global::tryAGI.OpenAI.EnvironmentFileResourceObject.AgentEnvironmentFile)
        {
            this.Object = @object;
            this.EnvironmentId = environmentId ?? throw new global::System.ArgumentNullException(nameof(environmentId));
            this.Path = path ?? throw new global::System.ArgumentNullException(nameof(path));
            this.SizeBytes = sizeBytes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EnvironmentFileResource" /> class.
        /// </summary>
        public EnvironmentFileResource()
        {
        }

    }
}