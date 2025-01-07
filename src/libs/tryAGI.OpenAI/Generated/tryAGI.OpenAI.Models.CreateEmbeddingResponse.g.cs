
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateEmbeddingResponse
    {
        /// <summary>
        /// The list of embeddings generated by the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding> Data { get; set; }

        /// <summary>
        /// The name of the model used to generate the embedding.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Model { get; set; }

        /// <summary>
        /// The object type, which is always "list".
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEmbeddingResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.CreateEmbeddingResponseObject Object { get; set; }

        /// <summary>
        /// The usage information for the request.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("usage")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.CreateEmbeddingResponseUsage Usage { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponse" /> class.
        /// </summary>
        /// <param name="data">
        /// The list of embeddings generated by the model.
        /// </param>
        /// <param name="model">
        /// The name of the model used to generate the embedding.
        /// </param>
        /// <param name="object">
        /// The object type, which is always "list".
        /// </param>
        /// <param name="usage">
        /// The usage information for the request.
        /// </param>
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
        public CreateEmbeddingResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Embedding> data,
            string model,
            global::tryAGI.OpenAI.CreateEmbeddingResponseUsage usage,
            global::tryAGI.OpenAI.CreateEmbeddingResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.Model = model ?? throw new global::System.ArgumentNullException(nameof(model));
            this.Usage = usage ?? throw new global::System.ArgumentNullException(nameof(usage));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEmbeddingResponse" /> class.
        /// </summary>
        public CreateEmbeddingResponse()
        {
        }
    }
}