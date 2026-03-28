
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CompactResponseMethodPublicBody
    {
        /// <summary>
        /// Model ID used to generate the response, like `gpt-5` or `o3`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](/docs/models) to browse and compare available models.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ModelIdsCompactionJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.ModelIdsCompaction Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("input")]
        public global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? Input { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("previous_response_id")]
        public string? PreviousResponseId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("instructions")]
        public string? Instructions { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_key")]
        public string? PromptCacheKey { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactResponseMethodPublicBody" /> class.
        /// </summary>
        /// <param name="model">
        /// Model ID used to generate the response, like `gpt-5` or `o3`. OpenAI offers a wide range of models with different capabilities, performance characteristics, and price points. Refer to the [model guide](/docs/models) to browse and compare available models.
        /// </param>
        /// <param name="input"></param>
        /// <param name="previousResponseId"></param>
        /// <param name="instructions"></param>
        /// <param name="promptCacheKey"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CompactResponseMethodPublicBody(
            global::tryAGI.OpenAI.ModelIdsCompaction model,
            global::tryAGI.OpenAI.OneOf<string, global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>>? input,
            string? previousResponseId,
            string? instructions,
            string? promptCacheKey)
        {
            this.Model = model;
            this.Input = input;
            this.PreviousResponseId = previousResponseId;
            this.Instructions = instructions;
            this.PromptCacheKey = promptCacheKey;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CompactResponseMethodPublicBody" /> class.
        /// </summary>
        public CompactResponseMethodPublicBody()
        {
        }
    }
}