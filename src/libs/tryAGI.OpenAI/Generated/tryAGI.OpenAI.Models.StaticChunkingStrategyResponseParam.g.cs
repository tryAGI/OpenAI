
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class StaticChunkingStrategyResponseParam
    {
        /// <summary>
        /// Always `static`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.StaticChunkingStrategyResponseParamTypeJsonConverter))]
        public global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType Type { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("static")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.StaticChunkingStrategy Static { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `static`.
        /// </param>
        /// <param name="static"></param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public StaticChunkingStrategyResponseParam(
            global::tryAGI.OpenAI.StaticChunkingStrategy @static,
            global::tryAGI.OpenAI.StaticChunkingStrategyResponseParamType type)
        {
            this.Static = @static ?? throw new global::System.ArgumentNullException(nameof(@static));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="StaticChunkingStrategyResponseParam" /> class.
        /// </summary>
        public StaticChunkingStrategyResponseParam()
        {
        }
    }
}