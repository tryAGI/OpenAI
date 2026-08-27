
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents a container created with /v1/containers.
    /// </summary>
    public sealed partial class BetaContainerReferenceResource
    {
        /// <summary>
        /// The environment type. Always `container_reference`.<br/>
        /// Default Value: container_reference
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaContainerReferenceResourceType.ContainerReference</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaContainerReferenceResourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaContainerReferenceResourceType Type { get; set; } = global::tryAGI.OpenAI.BetaContainerReferenceResourceType.ContainerReference;

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
        /// Initializes a new instance of the <see cref="BetaContainerReferenceResource" /> class.
        /// </summary>
        /// <param name="containerId"></param>
        /// <param name="type">
        /// The environment type. Always `container_reference`.<br/>
        /// Default Value: container_reference
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaContainerReferenceResource(
            string containerId,
            global::tryAGI.OpenAI.BetaContainerReferenceResourceType type = global::tryAGI.OpenAI.BetaContainerReferenceResourceType.ContainerReference)
        {
            this.Type = type;
            this.ContainerId = containerId ?? throw new global::System.ArgumentNullException(nameof(containerId));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaContainerReferenceResource" /> class.
        /// </summary>
        public BetaContainerReferenceResource()
        {
        }

        /// <summary>
        /// Creates a new <see cref="BetaContainerReferenceResource"/> from its single non-const required field,
        /// hardcoding any const discriminator fields.
        /// </summary>
        public static BetaContainerReferenceResource FromContainerId(string containerId)
        {
            return new BetaContainerReferenceResource
            {
                ContainerId = containerId,
            };
        }

    }
}