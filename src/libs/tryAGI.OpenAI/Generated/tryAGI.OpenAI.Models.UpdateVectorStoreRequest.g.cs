
#pragma warning disable CS0618 // Type or member is obsolete

#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class UpdateVectorStoreRequest
    {
        /// <summary>
        /// The name of the vector store.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("name")]
        public string? Name { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("expires_after")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.AllOfJsonConverter<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>))]
        public global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? ExpiresAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorStoreRequest" /> class.
        /// </summary>
        /// <param name="name">
        /// The name of the vector store.
        /// </param>
        /// <param name="expiresAfter"></param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UpdateVectorStoreRequest(
            string? name,
            global::tryAGI.OpenAI.AllOf<global::tryAGI.OpenAI.VectorStoreExpirationAfter, object>? expiresAfter,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Name = name;
            this.ExpiresAfter = expiresAfter;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UpdateVectorStoreRequest" /> class.
        /// </summary>
        public UpdateVectorStoreRequest()
        {
        }
    }
}