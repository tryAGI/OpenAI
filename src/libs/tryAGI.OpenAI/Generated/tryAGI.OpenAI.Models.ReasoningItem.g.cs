
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response.
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemType Type { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningItemContentItem> Content { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="content">
        /// Reasoning text contents.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningItemContentItem> content,
            global::tryAGI.OpenAI.ReasoningItemType type,
            global::tryAGI.OpenAI.ReasoningItemStatus? status)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Content = content ?? throw new global::System.ArgumentNullException(nameof(content));
            this.Type = type;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }
    }
}