
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The conversation that this response belonged to. Input items and output items from this response were automatically added to this conversation.
    /// </summary>
    public sealed partial class Conversation22
    {
        /// <summary>
        /// The unique ID of the conversation that this response was associated with.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public string Id { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation22" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the conversation that this response was associated with.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public Conversation22(
            string id)
        {
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Conversation22" /> class.
        /// </summary>
        public Conversation22()
        {
        }
    }
}