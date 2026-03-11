
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Automatic thread title preferences for the session.
    /// </summary>
    public sealed partial class ChatSessionAutomaticThreadTitling
    {
        /// <summary>
        /// Whether automatic thread titling is enabled.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("enabled")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public bool Enabled { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionAutomaticThreadTitling" /> class.
        /// </summary>
        /// <param name="enabled">
        /// Whether automatic thread titling is enabled.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionAutomaticThreadTitling(
            bool enabled)
        {
            this.Enabled = enabled;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionAutomaticThreadTitling" /> class.
        /// </summary>
        public ChatSessionAutomaticThreadTitling()
        {
        }
    }
}