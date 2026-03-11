
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// ChatKit configuration for the session.
    /// </summary>
    public sealed partial class ChatSessionChatkitConfiguration
    {
        /// <summary>
        /// Automatic thread titling preferences.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automatic_thread_titling")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling AutomaticThreadTitling { get; set; } = default!;

        /// <summary>
        /// Upload settings for the session.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ChatSessionFileUpload FileUpload { get; set; } = default!;

        /// <summary>
        /// History retention configuration.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public global::tryAGI.OpenAI.ChatSessionHistory History { get; set; } = default!;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionChatkitConfiguration" /> class.
        /// </summary>
        /// <param name="automaticThreadTitling">
        /// Automatic thread titling preferences.
        /// </param>
        /// <param name="fileUpload">
        /// Upload settings for the session.
        /// </param>
        /// <param name="history">
        /// History retention configuration.
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatSessionChatkitConfiguration(
            global::tryAGI.OpenAI.ChatSessionAutomaticThreadTitling automaticThreadTitling,
            global::tryAGI.OpenAI.ChatSessionFileUpload fileUpload,
            global::tryAGI.OpenAI.ChatSessionHistory history)
        {
            this.AutomaticThreadTitling = automaticThreadTitling ?? throw new global::System.ArgumentNullException(nameof(automaticThreadTitling));
            this.FileUpload = fileUpload ?? throw new global::System.ArgumentNullException(nameof(fileUpload));
            this.History = history ?? throw new global::System.ArgumentNullException(nameof(history));
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatSessionChatkitConfiguration" /> class.
        /// </summary>
        public ChatSessionChatkitConfiguration()
        {
        }
    }
}