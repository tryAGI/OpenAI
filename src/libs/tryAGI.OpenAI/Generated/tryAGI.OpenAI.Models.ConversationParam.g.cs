
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The conversation that this response belongs to.
    /// </summary>
    public sealed partial class ConversationParam
    {
        /// <summary>
        /// The unique ID of the conversation.<br/>
        /// Example: conv_123
        /// </summary>
        /// <example>conv_123</example>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationParam" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation.<br/>
        /// Example: conv_123
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ConversationParam(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConversationParam" /> class.
        /// </summary>
        public ConversationParam()
        {
        }
    }
}