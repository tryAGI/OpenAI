
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateVectorStoreRequestChunkingStrategyDiscriminator
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateVectorStoreRequestChunkingStrategyDiscriminatorTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType? Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreRequestChunkingStrategyDiscriminator" /> class.
        /// </summary>
        /// <param name="type"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateVectorStoreRequestChunkingStrategyDiscriminator(
            global::tryAGI.OpenAI.CreateVectorStoreRequestChunkingStrategyDiscriminatorType? type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateVectorStoreRequestChunkingStrategyDiscriminator" /> class.
        /// </summary>
        public CreateVectorStoreRequestChunkingStrategyDiscriminator()
        {
        }
    }
}