
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// This is returned when the chunking strategy is unknown. Typically, this is because the file was indexed before the `chunking_strategy` concept was introduced in the API.
    /// </summary>
    public sealed partial class OtherChunkingStrategyResponseParam
    {
        /// <summary>
        /// Always `other`.
        /// </summary>
        /// <default>"other"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        public string Type { get; set; } = "other";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherChunkingStrategyResponseParam" /> class.
        /// </summary>
        /// <param name="type">
        /// Always `other`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public OtherChunkingStrategyResponseParam(
            string type = "other")
        {
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="OtherChunkingStrategyResponseParam" /> class.
        /// </summary>
        public OtherChunkingStrategyResponseParam()
        {
        }

    }
}