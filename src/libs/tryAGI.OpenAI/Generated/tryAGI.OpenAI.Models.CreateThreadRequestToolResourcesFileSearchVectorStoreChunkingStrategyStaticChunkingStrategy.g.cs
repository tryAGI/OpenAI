
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy
    {
        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyTypeJsonConverter))]
        public global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy" /> class.
        /// </summary>
        /// <param name="static"></param>
        /// <param name="type">
        /// Always `static`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy(
            global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyStatic @static,
            global::tryAGI.OpenAI.CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategyType type)
        {
            this.Type = type;
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy" /> class.
        /// </summary>
        public CreateThreadRequestToolResourcesFileSearchVectorStoreChunkingStrategyStaticChunkingStrategy()
        {
        }
    }
}