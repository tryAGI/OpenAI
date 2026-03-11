
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Paginated list of groups that have access to a project.
    /// </summary>
    public sealed partial class ProjectGroupListResource
    {
        /// <summary>
        /// Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ProjectGroupListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.ProjectGroupListResourceObject Object { get; set; }

        /// <summary>
        /// Project group memberships returned in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup> Data { get; set; }

        /// <summary>
        /// Whether additional project group memberships are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, or `null` when there are no more results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroupListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `list`.
        /// </param>
        /// <param name="data">
        /// Project group memberships returned in the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether additional project group memberships are available.
        /// </param>
        /// <param name="next">
        /// Cursor to fetch the next page of results, or `null` when there are no more results.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ProjectGroupListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ProjectGroup> data,
            bool hasMore,
            global::tryAGI.OpenAI.ProjectGroupListResourceObject @object,
            string? next)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Object = @object;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ProjectGroupListResource" /> class.
        /// </summary>
        public ProjectGroupListResource()
        {
        }
    }
}