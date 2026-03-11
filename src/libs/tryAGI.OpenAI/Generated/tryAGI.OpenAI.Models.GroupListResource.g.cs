
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Paginated list of organization groups.
    /// </summary>
    public sealed partial class GroupListResource
    {
        /// <summary>
        /// Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.GroupListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.GroupListResourceObject Object { get; set; }

        /// <summary>
        /// Groups returned in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse> Data { get; set; }

        /// <summary>
        /// Whether additional groups are available when paginating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, or `null` if there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `list`.
        /// </param>
        /// <param name="data">
        /// Groups returned in the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether additional groups are available when paginating.
        /// </param>
        /// <param name="next">
        /// Cursor to fetch the next page of results, or `null` if there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public GroupListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupResponse> data,
            bool hasMore,
            global::tryAGI.OpenAI.GroupListResourceObject @object,
            string? next)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GroupListResource" /> class.
        /// </summary>
        public GroupListResource()
        {
        }
    }
}