
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// 
    /// </summary>
    public sealed partial class CreateConversationBody
    {
        /// <summary>
        /// Initial items to include in the conversation context. You may add up to 20 items at a time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Items { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationBody" /> class.
        /// </summary>
        /// <param name="items">
        /// Initial items to include in the conversation context. You may add up to 20 items at a time.
        /// </param>
        /// <param name="metadata"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationBody(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? items,
            object? metadata)
        {
            this.Items = items;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationBody" /> class.
        /// </summary>
        public CreateConversationBody()
        {
        }
    }
}