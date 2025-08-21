
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The conversation that this response belongs to. Input items and output items from this response are automatically added to this conversation.
    /// </summary>
    public sealed partial class Conversation2
    {
        /// <summary>
        /// The unique ID of the conversation.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation2" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Conversation2(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation2" /> class.
        /// </summary>
        public Conversation2()
        {
        }
    }
}