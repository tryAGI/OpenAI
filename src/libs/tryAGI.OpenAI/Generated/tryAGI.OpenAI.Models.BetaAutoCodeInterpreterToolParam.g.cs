
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Configuration for a code interpreter container. Optionally specify the IDs of the files to run the code on.
    /// </summary>
    public sealed partial class BetaAutoCodeInterpreterToolParam
    {
        /// <summary>
        /// Always `auto`.<br/>
        /// Default Value: auto
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType.Auto</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaAutoCodeInterpreterToolParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType Type { get; set; } = global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType.Auto;

        /// <summary>
        /// An optional list of uploaded files to make available to your code.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_ids")]
        public global::System.Collections.Generic.IList<string>? FileIds { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("memory_limit")]
        public global::tryAGI.OpenAI.BetaContainerMemoryLimit? MemoryLimit { get; set; }

        /// <summary>
        /// Network access policy for the container.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("network_policy")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.NetworkPolicy5JsonConverter))]
        public global::tryAGI.OpenAI.NetworkPolicy5? NetworkPolicy { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAutoCodeInterpreterToolParam" /> class.
        /// </summary>
        /// <param name="fileIds">
        /// An optional list of uploaded files to make available to your code.
        /// </param>
        /// <param name="memoryLimit"></param>
        /// <param name="networkPolicy">
        /// Network access policy for the container.
        /// </param>
        /// <param name="type">
        /// Always `auto`.<br/>
        /// Default Value: auto
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaAutoCodeInterpreterToolParam(
            global::System.Collections.Generic.IList<string>? fileIds,
            global::tryAGI.OpenAI.BetaContainerMemoryLimit? memoryLimit,
            global::tryAGI.OpenAI.NetworkPolicy5? networkPolicy,
            global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType type = global::tryAGI.OpenAI.BetaAutoCodeInterpreterToolParamType.Auto)
        {
            this.Type = type;
            this.FileIds = fileIds;
            this.MemoryLimit = memoryLimit;
            this.NetworkPolicy = networkPolicy;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaAutoCodeInterpreterToolParam" /> class.
        /// </summary>
        public BetaAutoCodeInterpreterToolParam()
        {
        }

    }
}