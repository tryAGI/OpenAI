
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class LiveHostedShellContainerAutoParam
    {
        /// <summary>
        /// Automatically creates a container for this request<br/>
        /// Default Value: container_auto
        /// </summary>
        /// <default>global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType.ContainerAuto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.LiveHostedShellContainerAutoParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType Type { get; set; } = global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType.ContainerAuto;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        public global::tryAGI.OpenAI.LiveContainerMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        public global::tryAGI.OpenAI.NetworkPolicyVariant1? NetworkPolicy { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("skills")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? Skills { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellContainerAutoParam" /> class.
        /// </summary>
        /// <param name="fileIds"></param>
        /// <param name="memoryLimit"></param>
        /// <param name="networkPolicy"></param>
        /// <param name="skills"></param>
        /// <param name="type">
        /// Automatically creates a container for this request<br/>
        /// Default Value: container_auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public LiveHostedShellContainerAutoParam(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.LiveContainerMemoryLimit? memoryLimit,
            global::tryAGI.OpenAI.NetworkPolicyVariant1? networkPolicy,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SkillsVariant1Item>? skills,
            global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType type = global::tryAGI.OpenAI.LiveHostedShellContainerAutoParamType.ContainerAuto)
        {
            this.Type = type;
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
            this.NetworkPolicy = networkPolicy;
            this.Skills = skills;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LiveHostedShellContainerAutoParam" /> class.
        /// </summary>
        public LiveHostedShellContainerAutoParam()
        {
        }

    }
}