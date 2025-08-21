
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationItemsRequest
    {
        /// <summary>
        /// The items to add to the conversation. You may add up to 20 items at a time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem> Items { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationItemsRequest" /> class.
        /// </summary>
        /// <param name="items">
        /// The items to add to the conversation. You may add up to 20 items at a time.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationItemsRequest(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem> items)
        {
            this.Items = items ?? throw new global::System.ArgumentNullException(nameof(items));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationItemsRequest" /> class.
        /// </summary>
        public CreateConversationItemsRequest()
        {
        }
    }
}