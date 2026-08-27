
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A file input to the model.
    /// </summary>
    public sealed partial class BetaInputFileContent
    {
        /// <summary>
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </summary>
        /// <default>global::tryAGI.OpenAI.BetaInputFileContentType.InputFile</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaInputFileContentTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaInputFileContentType Type { get; set; } = global::tryAGI.OpenAI.BetaInputFileContentType.InputFile;

        /// <summary>
        ///
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_id")]
        public string? FileId { get; set; }

        /// <summary>
        /// The name of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("filename")]
        public string? Filename { get; set; }

        /// <summary>
        /// The content of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_data")]
        public string? FileData { get; set; }

        /// <summary>
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("prompt_cache_breakpoint")]
        public global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? PromptCacheBreakpoint { get; set; }

        /// <summary>
        /// The URL of the file to be sent to the model.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("file_url")]
        public string? FileUrl { get; set; }

        /// <summary>
        /// The detail level of the file to be sent to the model. Use `auto` to let the system select the detail level; for GPT-5.6 and later models, `auto` uses high-quality rendering, which may increase input token usage. Use `low` for lower-cost rendering, or `high` to render the file at higher quality. Defaults to `auto`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("detail")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFileInputDetailJsonConverter))]
        public global::tryAGI.OpenAI.BetaFileInputDetail? Detail { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputFileContent" /> class.
        /// </summary>
        /// <param name="fileId"></param>
        /// <param name="filename">
        /// The name of the file to be sent to the model.
        /// </param>
        /// <param name="fileData">
        /// The content of the file to be sent to the model.
        /// </param>
        /// <param name="promptCacheBreakpoint">
        /// Marks the exact end of a reusable prompt prefix. The breakpoint inherits its TTL from the request's `prompt_cache_options.ttl`; the boundary is not rounded to a token block.
        /// </param>
        /// <param name="fileUrl">
        /// The URL of the file to be sent to the model.
        /// </param>
        /// <param name="detail">
        /// The detail level of the file to be sent to the model. Use `auto` to let the system select the detail level; for GPT-5.6 and later models, `auto` uses high-quality rendering, which may increase input token usage. Use `low` for lower-cost rendering, or `high` to render the file at higher quality. Defaults to `auto`.
        /// </param>
        /// <param name="type">
        /// The type of the input item. Always `input_file`.<br/>
        /// Default Value: input_file
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaInputFileContent(
            string? fileId,
            string? filename,
            string? fileData,
            global::tryAGI.OpenAI.BetaPromptCacheBreakpointConfig? promptCacheBreakpoint,
            string? fileUrl,
            global::tryAGI.OpenAI.BetaFileInputDetail? detail,
            global::tryAGI.OpenAI.BetaInputFileContentType type = global::tryAGI.OpenAI.BetaInputFileContentType.InputFile)
        {
            this.Type = type;
            this.FileId = fileId;
            this.Filename = filename;
            this.FileData = fileData;
            this.PromptCacheBreakpoint = promptCacheBreakpoint;
            this.FileUrl = fileUrl;
            this.Detail = detail;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaInputFileContent" /> class.
        /// </summary>
        public BetaInputFileContent()
        {
        }

    }
}