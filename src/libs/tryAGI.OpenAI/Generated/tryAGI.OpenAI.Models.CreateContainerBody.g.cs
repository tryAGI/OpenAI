
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateContainerBody
    {
        /// <summary>
        /// Name of the container to create.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Name { get; set; } = default!;

        /// <summary>
        /// IDs of files to copy to the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        public global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? ExpiresAfter { get; set; }

        /// <summary>
        /// An optional list of skills referenced by id or inline data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? Skills { get; set; }

        /// <summary>
        /// Optional memory limit for the container. Defaults to "1g".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateContainerBodyMemoryLimitJsonConverter))]
        public global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        /// Network access policy for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicyJsonConverter))]
        public global::tryAGI.OpenAI.NetworkPolicy? NetworkPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        /// <param name="name">
        /// Name of the container to create.
        /// </param>
        /// <param name="fileIds">
        /// IDs of files to copy to the container.
        /// </param>
        /// <param name="expiresAfter">
        /// Container expiration time in seconds relative to the 'anchor' time.
        /// </param>
        /// <param name="skills">
        /// An optional list of skills referenced by id or inline data.
        /// </param>
        /// <param name="memoryLimit">
        /// Optional memory limit for the container. Defaults to "1g".
        /// </param>
        /// <param name="networkPolicy">
        /// Network access policy for the container.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateContainerBody(
            string name,
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.CreateContainerBodyExpiresAfter? expiresAfter,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem>? skills,
            global::tryAGI.OpenAI.CreateContainerBodyMemoryLimit? memoryLimit,
            global::tryAGI.OpenAI.NetworkPolicy? networkPolicy)
        {
            this.Name = name ?? throw new global::System.ArgumentNullException(nameof(name));
            this.FileIds = fileIds;
            this.ExpiresAfter = expiresAfter;
            this.Skills = skills;
            this.MemoryLimit = memoryLimit;
            this.NetworkPolicy = networkPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateContainerBody" /> class.
        /// </summary>
        public CreateContainerBody()
        {
        }
    }
}