
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class InviteListResponse
    {
        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite> Data { get; set; }

        /// <summary>
        /// The first `invite_id` in the retrieved `list`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        public string? FirstId { get; set; }

        /// <summary>
        /// The `has_more` property is used for pagination to indicate there are additional results.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        public bool? HasMore { get; set; }

        /// <summary>
        /// The last `invite_id` in the retrieved `list`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        public string? LastId { get; set; }

        /// <summary>
        /// The object type, which is always `list`
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.InviteListResponseObjectJsonConverter))]
        public global::tryAGI.OpenAI.InviteListResponseObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteListResponse" /> class.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="firstId">
        /// The first `invite_id` in the retrieved `list`
        /// </param>
        /// <param name="hasMore">
        /// The `has_more` property is used for pagination to indicate there are additional results.
        /// </param>
        /// <param name="lastId">
        /// The last `invite_id` in the retrieved `list`
        /// </param>
        /// <param name="object">
        /// The object type, which is always `list`
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public InviteListResponse(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.Invite> data,
            string? firstId,
            bool? hasMore,
            string? lastId,
            global::tryAGI.OpenAI.InviteListResponseObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId;
            this.HasMore = hasMore;
            this.LastId = lastId;
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InviteListResponse" /> class.
        /// </summary>
        public InviteListResponse()
        {
        }
    }
}