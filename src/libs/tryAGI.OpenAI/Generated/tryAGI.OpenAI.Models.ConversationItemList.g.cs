
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A list of Conversation items.
    /// </summary>
    public sealed partial class ConversationItemList
    {
        /// <summary>
        /// A list of conversation items.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("data")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem> Data { get; set; }

        /// <summary>
        /// The ID of the first item in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("first_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string FirstId { get; set; }

        /// <summary>
        /// Whether there are more items available.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("has_more")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required bool HasMore { get; set; }

        /// <summary>
        /// The ID of the last item in the list.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("last_id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string LastId { get; set; }

        /// <summary>
        /// The type of object returned, must be `list`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("object")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ConversationItemListObjectJsonConverter))]
        public global::tryAGI.OpenAI.ConversationItemListObject Object { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemList" /> class.
        /// </summary>
        /// <param name="data">
        /// A list of conversation items.
        /// </param>
        /// <param name="firstId">
        /// The ID of the first item in the list.
        /// </param>
        /// <param name="hasMore">
        /// Whether there are more items available.
        /// </param>
        /// <param name="lastId">
        /// The ID of the last item in the list.
        /// </param>
        /// <param name="object">
        /// The type of object returned, must be `list`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationItemList(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ConversationItem> data,
            string firstId,
            bool hasMore,
            string lastId,
            global::tryAGI.OpenAI.ConversationItemListObject @object)
        {
            this.Data = data ?? throw new global::System.ArgumentNullException(nameof(data));
            this.FirstId = firstId ?? throw new global::System.ArgumentNullException(nameof(firstId));
            this.HasMore = hasMore;
            this.LastId = lastId ?? throw new global::System.ArgumentNullException(nameof(lastId));
            this.Object = @object;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationItemList" /> class.
        /// </summary>
        public ConversationItemList()
        {
        }
    }
}