
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerAutoParam
    {
        /// <summary>
        /// Automatically creates a container for this request<br/>
        /// Default Value: container_auto
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerAutoParamType.ContainerAuto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerAutoParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerAutoParamType Type { get; set; } = global::tryAGI.OpenAI.ContainerAutoParamType.ContainerAuto;

        /// <summary>
        /// An optional list of uploaded files to make available to your code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        public global::tryAGI.OpenAI.ContainerMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        /// Network access policy for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicy3JsonConverter))]
        public global::tryAGI.OpenAI.NetworkPolicy3? NetworkPolicy { get; set; }

        /// <summary>
        /// An optional list of skills referenced by id or inline data.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerAutoParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Automatically creates a container for this request<br/>
        /// Default Value: container_auto
        /// </param>
        /// <param name="fileIds">
        /// An optional list of uploaded files to make available to your code.
        /// </param>
        /// <param name="memoryLimit"></param>
        /// <param name="networkPolicy">
        /// Network access policy for the container.
        /// </param>
        /// <param name="skills">
        /// An optional list of skills referenced by id or inline data.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerAutoParam(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.ContainerMemoryLimit? memoryLimit,
            global::tryAGI.OpenAI.NetworkPolicy3? networkPolicy,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsItem2>? skills,
            global::tryAGI.OpenAI.ContainerAutoParamType type = global::tryAGI.OpenAI.ContainerAutoParamType.ContainerAuto)
        {
            this.Type = type;
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
            this.NetworkPolicy = networkPolicy;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerAutoParam" /> class.
        /// </summary>
        public ContainerAutoParam()
        {
        }
    }
}