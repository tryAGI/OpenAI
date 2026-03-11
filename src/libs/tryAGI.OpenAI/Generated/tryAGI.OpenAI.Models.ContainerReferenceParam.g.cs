
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class ContainerReferenceParam
    {
        /// <summary>
        /// References a container created with the /v1/containers endpoint<br/>
        /// Default Value: container_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerReferenceParamType.ContainerReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerReferenceParamType Type { get; set; } = global::tryAGI.OpenAI.ContainerReferenceParamType.ContainerReference;

        /// <summary>
        /// The ID of the referenced container.<br/>
        /// Example: cntr_123
        /// </summary>
        /// <example>cntr_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceParam" /> class.
        /// </summary>
        /// <param name="type">
        /// References a container created with the /v1/containers endpoint<br/>
        /// Default Value: container_reference
        /// </param>
        /// <param name="containerId">
        /// The ID of the referenced container.<br/>
        /// Example: cntr_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerReferenceParam(
            string containerId,
            global::tryAGI.OpenAI.ContainerReferenceParamType type = global::tryAGI.OpenAI.ContainerReferenceParamType.ContainerReference)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceParam" /> class.
        /// </summary>
        public ContainerReferenceParam()
        {
        }
    }
}