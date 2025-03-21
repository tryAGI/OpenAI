
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class VectorStoreSearchResultContentObject
    {
        /// <summary>
        /// The type of content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.VectorStoreSearchResultContentObjectTypeJsonConverter))]
        public global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType Type { get; set; }

        /// <summary>
        /// The text content returned from search.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("text")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Text { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultContentObject" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of content.
        /// </param>
        /// <param name="text">
        /// The text content returned from search.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public VectorStoreSearchResultContentObject(
            string text,
            global::tryAGI.OpenAI.VectorStoreSearchResultContentObjectType type)
        {
            this.Text = text ?? throw new global::System.ArgumentNullException(nameof(text));
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="VectorStoreSearchResultContentObject" /> class.
        /// </summary>
        public VectorStoreSearchResultContentObject()
        {
        }
    }
}