
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    ///
    /// </summary>
    public sealed partial class ListExternalKeysResource
    {
        /// <summary>
        /// Default Value: list
        /// </summary>
        /// <default>global::tryAGI.OpenAI.ListExternalKeysResourceObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ListExternalKeysResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ListExternalKeysResourceObject Object { get; set; } = global::tryAGI.OpenAI.ListExternalKeysResourceObject.List;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalKeyResource> Data { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExternalKeysResource" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="hasMore"></param>
        /// <param name="firstId"></param>
        /// <param name="lastId"></param>
        /// <param name="object">
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ListExternalKeysResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ExternalKeyResource> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::tryAGI.OpenAI.ListExternalKeysResourceObject @object = global::tryAGI.OpenAI.ListExternalKeysResourceObject.List)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ListExternalKeysResource" /> class.
        /// </summary>
        public ListExternalKeysResource()
        {
        }

    }
}