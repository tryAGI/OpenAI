
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A description of the chain of thought used by a reasoning model while generating<br/>
    /// a response. Be sure to include these items in your `input` to the Responses API<br/>
    /// for subsequent turns of a conversation if you are manually<br/>
    /// [managing context](/docs/guides/conversation-state).
    /// </summary>
    public sealed partial class BetaReasoningItem
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The type of the object. Always `reasoning`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaReasoningItemType Type { get; set; }

        /// <summary>
        /// The unique identifier of the reasoning content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("encrypted_content")]
        public string? EncryptedContent { get; set; }

        /// <summary>
        /// Reasoning summary content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("summary")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent> Summary { get; set; }

        /// <summary>
        /// Reasoning text content.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("content")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? Content { get; set; }

        /// <summary>
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaReasoningItemStatusJsonConverter))]
        public global::tryAGI.OpenAI.BetaReasoningItemStatus? Status { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaReasoningItem" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique identifier of the reasoning content.
        /// </param>
        /// <param name="summary">
        /// Reasoning summary content.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the object. Always `reasoning`.
        /// </param>
        /// <param name="encryptedContent"></param>
        /// <param name="content">
        /// Reasoning text content.
        /// </param>
        /// <param name="status">
        /// The status of the item. One of `in_progress`, `completed`, or<br/>
        /// `incomplete`. Populated when items are returned via API.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaReasoningItem(
            string id,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaSummaryTextContent> summary,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaReasoningItemType type,
            string? encryptedContent,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaReasoningTextContent>? content,
            global::tryAGI.OpenAI.BetaReasoningItemStatus? status)
        {
            this.Agent = agent;
            this.Type = type;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.EncryptedContent = encryptedContent;
            this.Summary = summary ?? throw new global::System.ArgumentNullException(nameof(summary));
            this.Content = content;
            this.Status = status;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaReasoningItem" /> class.
        /// </summary>
        public BetaReasoningItem()
        {
        }

    }
}