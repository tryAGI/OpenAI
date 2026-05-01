
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Paginated list of user objects returned when inspecting group membership.
    /// </summary>
    public sealed partial class UserListResource
    {
        /// <summary>
        /// Always `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UserListResourceObjectJsonConverter))]
        public global::tryAGI.OpenAI.UserListResourceObject Object { get; set; }

        /// <summary>
        /// Users in the current page.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser> Data { get; set; }

        /// <summary>
        /// Whether more users are available when paginating.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// Cursor to fetch the next page of results, or `null` when no further users are available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("next")]
        public string? Next { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResource" /> class.
        /// </summary>
        /// <param name="data">
        /// Users in the current page.
        /// </param>
        /// <param name="hasMore">
        /// Whether more users are available when paginating.
        /// </param>
        /// <param name="object">
        /// Always `list`.
        /// </param>
        /// <param name="next">
        /// Cursor to fetch the next page of results, or `null` when no further users are available.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public UserListResource(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.GroupUser> data,
            bool hasMore,
            global::tryAGI.OpenAI.UserListResourceObject @object,
            string? next)
        {
            this.Object = @object;
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.HasMore = hasMore;
            this.Next = next;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UserListResource" /> class.
        /// </summary>
        public UserListResource()
        {
        }
    }
}