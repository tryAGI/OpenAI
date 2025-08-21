
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Create a conversation
    /// </summary>
    public sealed partial class CreateConversationRequest
    {
        /// <summary>
        /// Initial items to include in the conversation context.<br/>
        /// You may add up to 20 items at a time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("items")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? Items { get; set; }

        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        /// <param name="items">
        /// Initial items to include in the conversation context.<br/>
        /// You may add up to 20 items at a time.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateConversationRequest(
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.InputItem>? items,
            global::System.Collections.Generic.Dictionary<string, string>? metadata)
        {
            this.Items = items;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateConversationRequest" /> class.
        /// </summary>
        public CreateConversationRequest()
        {
        }
    }
}