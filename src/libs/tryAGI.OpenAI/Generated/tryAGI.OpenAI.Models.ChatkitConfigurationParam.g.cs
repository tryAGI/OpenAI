
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Optional per-session configuration settings for ChatKit behavior.
    /// </summary>
    public sealed partial class ChatkitConfigurationParam
    {
        /// <summary>
        /// Configuration for automatic thread titling. When omitted, automatic thread titling is enabled by default.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("automatic_thread_titling")]
        public global::tryAGI.OpenAI.AutomaticThreadTitlingParam? AutomaticThreadTitling { get; set; }

        /// <summary>
        /// Configuration for upload enablement and limits. When omitted, uploads are disabled by default (max_files 10, max_file_size 512 MB).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_upload")]
        public global::tryAGI.OpenAI.FileUploadParam? FileUpload { get; set; }

        /// <summary>
        /// Configuration for chat history retention. When omitted, history is enabled by default with no limit on recent_threads (null).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("history")]
        public global::tryAGI.OpenAI.HistoryParam? History { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitConfigurationParam" /> class.
        /// </summary>
        /// <param name="automaticThreadTitling">
        /// Configuration for automatic thread titling. When omitted, automatic thread titling is enabled by default.
        /// </param>
        /// <param name="fileUpload">
        /// Configuration for upload enablement and limits. When omitted, uploads are disabled by default (max_files 10, max_file_size 512 MB).
        /// </param>
        /// <param name="history">
        /// Configuration for chat history retention. When omitted, history is enabled by default with no limit on recent_threads (null).
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public ChatkitConfigurationParam(
            global::tryAGI.OpenAI.AutomaticThreadTitlingParam? automaticThreadTitling,
            global::tryAGI.OpenAI.FileUploadParam? fileUpload,
            global::tryAGI.OpenAI.HistoryParam? history)
        {
            this.AutomaticThreadTitling = automaticThreadTitling;
            this.FileUpload = fileUpload;
            this.History = history;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChatkitConfigurationParam" /> class.
        /// </summary>
        public ChatkitConfigurationParam()
        {
        }
    }
}