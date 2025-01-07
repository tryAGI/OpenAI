
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The default strategy. This strategy currently uses a `max_chunk_size_tokens` of `800` and `chunk_overlap_tokens` of `400`.
    /// </summary>
    public sealed partial class AutoChunkingStrategyRequestParam
    {
        /// <summary>
        /// Always `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AutoChunkingStrategyRequestParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChunkingStrategyRequestParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `auto`.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public AutoChunkingStrategyRequestParam(
            global::tryAGI.OpenAI.AutoChunkingStrategyRequestParamType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AutoChunkingStrategyRequestParam" /> class.
        /// </summary>
        public AutoChunkingStrategyRequestParam()
        {
        }
    }
}