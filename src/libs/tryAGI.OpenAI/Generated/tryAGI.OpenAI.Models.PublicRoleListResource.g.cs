
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Paginated list of roles available on an organization or project.
    /// </summary>
    public sealed partial class PublicRoleListResource
    {
        /// <summary>
        /// Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.PublicRoleListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.PublicRoleListResourceObject Object { get; set; }

        /// <summary>
        /// Roles returned in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role> Data { get; set; }

        /// <summary>
        /// Whether more roles are available when paginating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, or `null` when there are no additional roles.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRoleListResource" /> class.
        /// </summary>
        /// <param name="object">
        /// Always `list`.
        /// </param>
        /// <param name="data">
        /// Roles returned in the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more roles are available when paginating.
        /// </param>
        /// <param name="next">
        /// Cursor to fetch the next page of results, or `null` when there are no additional roles.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public PublicRoleListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Role> data,
            bool hasMore,
            string? next,
            global::tryAGI.OpenAI.PublicRoleListResourceObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Next = next ?? throw new global::System.ArgumentNullException(nameof(next));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="PublicRoleListResource" /> class.
        /// </summary>
        public PublicRoleListResource()
        {
        }
    }
}