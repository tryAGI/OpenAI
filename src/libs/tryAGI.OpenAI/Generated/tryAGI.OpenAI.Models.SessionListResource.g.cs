
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A page of Agents API resources, with IDs for retrieving additional pages.
    /// </summary>
    public sealed partial class SessionListResource
    {
        /// <summary>
        /// The object type, which is always `list`.<br/>
        /// Default Value: list
        /// </summary>
        /// <default>global::tryAGI.OpenAI.SessionListResourceObject.List</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.SessionListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.SessionListResourceObject Object { get; set; } = global::tryAGI.OpenAI.SessionListResourceObject.List;

        /// <summary>
        /// The resources returned in this page, in the requested sort order.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource> Data { get; set; }

        /// <summary>
        /// The ID of the first resource in `data`, or `null` if the page is empty.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The ID of the last resource in `data`, or `null` if the page is empty. Pass this as `after` with the same order and filters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// Whether there are more resources to retrieve after this page.
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
        /// Initializes a new instance of the <see cref="SessionListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// The resources returned in this page, in the requested sort order.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more resources to retrieve after this page.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first resource in `data`, or `null` if the page is empty.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last resource in `data`, or `null` if the page is empty. Pass this as `after` with the same order and filters.
        /// </param>
        /// <param name="object">
        /// The object type, which is always `list`.<br/>
        /// Default Value: list
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public SessionListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.SessionResource> data,
            bool hasMore,
            string? firstId,
            string? lastId,
            global::tryAGI.OpenAI.SessionListResourceObject @object = global::tryAGI.OpenAI.SessionListResourceObject.List)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.LastId = lastId;
            this.HasMore = hasMore;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SessionListResource" /> class.
        /// </summary>
        public SessionListResource()
        {
        }

    }
}