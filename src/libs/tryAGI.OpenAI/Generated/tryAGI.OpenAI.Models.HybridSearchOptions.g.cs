
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class HybridSearchOptions
    {
        /// <summary>
        /// The weight of the embedding in the reciprocal ranking fusion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double EmbeddingWeight { get; set; } = default!;

        /// <summary>
        /// The weight of the text in the reciprocal ranking fusion.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text_weight")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double TextWeight { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridSearchOptions" /> class.
        /// </summary>
        /// <param name="embeddingWeight">
        /// The weight of the embedding in the reciprocal ranking fusion.
        /// </param>
        /// <param name="textWeight">
        /// The weight of the text in the reciprocal ranking fusion.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public HybridSearchOptions(
            double embeddingWeight,
            double textWeight)
        {
            this.EmbeddingWeight = embeddingWeight;
            this.TextWeight = textWeight;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="HybridSearchOptions" /> class.
        /// </summary>
        public HybridSearchOptions()
        {
        }
    }
}