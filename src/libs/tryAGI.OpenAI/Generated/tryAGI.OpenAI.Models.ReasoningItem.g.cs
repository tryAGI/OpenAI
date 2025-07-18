
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response. Be sure to include these items in your `input` to the Responses API<br/>
    /// for subsequent turns of a conversation if you are manually <br/>
    /// [managing context](/docs/guides/conversation-state).
    /// </summary>
    public sealed partial class ReasoningItem
    {
        /// <summary>
        /// The encrypted content of the reasoning item - populated when a response is<br/>
        /// generated with `reasoning.encrypted_content` in the `include` parameter.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemStatusJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Reasoning text contents.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningItemSummaryItem> Summary { get; set; }

        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.ReasoningItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.ReasoningItemType Type { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        /// <param name="encryptedContent">
        /// The encrypted content of the reasoning item - populated when a response is<br/>
        /// generated with `reasoning.encrypted_content` in the `include` parameter.
        /// </param>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
        /// <param name="summary">
        /// Reasoning text contents.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.ReasoningItemSummaryItem> summary,
            string? encryptedContent,
            global::tryAGI.OpenAI.ReasoningItemStatus? status,
            global::tryAGI.OpenAI.ReasoningItemType type)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.EncryptedContent = encryptedContent;
            this.Status = status;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ReasoningItem" /> class.
        /// </summary>
        public ReasoningItem()
        {
        }
    }
}