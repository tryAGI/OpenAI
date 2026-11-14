
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Represents an embedding vector returned by embedding endpoint.
    /// </summary>
    public sealed partial class Embedding
    {
        /// <summary>
        /// The index of the embedding in the list of embeddings.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("index")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required int Index { get; set; }

        /// <summary>
        /// The embedding vector, returned as a list of floats when `encoding_format` is `float` (the default), or as a base64-encoded string when `encoding_format` is `base64`. The length of the vector depends on the model as listed in the [embedding guide](https://developers.openai.com/api/docs/guides/embeddings).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("embedding")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AnyOfJsonConverter<global::System.Collections.Generic.IList<float>, string>))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string> Embedding1 { get; set; }

        /// <summary>
        /// The object type, which is always "embedding".
        /// </summary>
        /// <default>"embedding"</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        public string Object { get; set; } = "embedding";

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        /// <param name="index">
        /// The index of the embedding in the list of embeddings.
        /// </param>
        /// <param name="embedding1">
        /// The embedding vector, returned as a list of floats when `encoding_format` is `float` (the default), or as a base64-encoded string when `encoding_format` is `base64`. The length of the vector depends on the model as listed in the [embedding guide](https://developers.openai.com/api/docs/guides/embeddings).
        /// </param>
        /// <param name="object">
        /// The object type, which is always "embedding".
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Embedding(
            int index,
            global::tryAGI.OpenAI.AnyOf<global::System.Collections.Generic.IList<float>, string> embedding1,
            string @object = "embedding")
        {
            this.Index = index;
            this.Embedding1 = embedding1;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Embedding" /> class.
        /// </summary>
        public Embedding()
        {
        }

    }
}