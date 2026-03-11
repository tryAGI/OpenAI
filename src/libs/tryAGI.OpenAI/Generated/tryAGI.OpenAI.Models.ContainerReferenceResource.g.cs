
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a container created with /v1/containers.
    /// </summary>
    public sealed partial class ContainerReferenceResource
    {
        /// <summary>
        /// The environment type. Always `container_reference`.<br/>
        /// Default Value: container_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ContainerReferenceResourceType.ContainerReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ContainerReferenceResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.ContainerReferenceResourceType Type { get; set; } = global::tryAGI.OpenAI.ContainerReferenceResourceType.ContainerReference;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("container_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string ContainerId { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceResource" /> class.
        /// </summary>
        /// <param name="type">
        /// The environment type. Always `container_reference`.<br/>
        /// Default Value: container_reference
        /// </param>
        /// <param name="containerId"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ContainerReferenceResource(
            string containerId,
            global::tryAGI.OpenAI.ContainerReferenceResourceType type = global::tryAGI.OpenAI.ContainerReferenceResourceType.ContainerReference)
        {
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ContainerReferenceResource" /> class.
        /// </summary>
        public ContainerReferenceResource()
        {
        }
    }
}