
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchResultItem
    {
        /// <summary>
        /// The ID of the vector store file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string FileId { get; set; } = default!;

        /// <summary>
        /// The name of the vector store file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Filename { get; set; } = default!;

        /// <summary>
        /// The similarity score for the result.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("score")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public double Score { get; set; } = default!;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("attributes")]
        public object? Attributes { get; set; }

        /// <summary>
        /// Content chunks from the file.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject> Content { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultItem" /> class.
        /// </summary>
        /// <param name="fileId">
        /// The ID of the vector store file.
        /// </param>
        /// <param name="filename">
        /// The name of the vector store file.
        /// </param>
        /// <param name="score">
        /// The similarity score for the result.
        /// </param>
        /// <param name="attributes"></param>
        /// <param name="content">
        /// Content chunks from the file.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreSearchResultItem(
            string fileId,
            string filename,
            double score,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.VectorStoreSearchResultContentObject> content,
            object? attributes)
        {
            this.FileId = fileId ?? throw new global::System.ArgumentNullException(nameof(fileId));
            this.Filename = filename ?? throw new global::System.ArgumentNullException(nameof(filename));
            this.Score = score;
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Attributes = attributes;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultItem" /> class.
        /// </summary>
        public VectorStoreSearchResultItem()
        {
        }
    }
}