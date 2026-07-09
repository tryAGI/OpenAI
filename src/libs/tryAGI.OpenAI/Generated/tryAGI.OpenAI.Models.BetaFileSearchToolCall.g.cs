
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// The results of a file search tool call. See the<br/>
    /// [file search guide](/docs/guides/tools-file-search) for more information.
    /// </summary>
    public sealed partial class BetaFileSearchToolCall
    {
        /// <summary>
        /// The agent that produced this item.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("agent")]
        public global::tryAGI.OpenAI.BetaAgentTag? Agent { get; set; }

        /// <summary>
        /// The unique ID of the file search tool call.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("id")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required string Id { get; set; }

        /// <summary>
        /// The type of the file search tool call. Always `file_search_call`.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallTypeJsonConverter))]
        public global::tryAGI.OpenAI.BetaFileSearchToolCallType Type { get; set; }

        /// <summary>
        /// The status of the file search tool call. One of `in_progress`,<br/>
        /// `searching`, `incomplete` or `failed`,
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("status")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.BetaFileSearchToolCallStatusJsonConverter))]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::tryAGI.OpenAI.BetaFileSearchToolCallStatus Status { get; set; }

        /// <summary>
        /// The queries used to search for files.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("queries")]
        [global::System.Text.Json.Serialization.JsonRequired]
        public required global::System.Collections.Generic.IList<string> Queries { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("results")]
        public global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? Results { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileSearchToolCall" /> class.
        /// </summary>
        /// <param name="id">
        /// The unique ID of the file search tool call.
        /// </param>
        /// <param name="status">
        /// The status of the file search tool call. One of `in_progress`,<br/>
        /// `searching`, `incomplete` or `failed`,
        /// </param>
        /// <param name="queries">
        /// The queries used to search for files.
        /// </param>
        /// <param name="agent">
        /// The agent that produced this item.
        /// </param>
        /// <param name="type">
        /// The type of the file search tool call. Always `file_search_call`.
        /// </param>
        /// <param name="results"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public BetaFileSearchToolCall(
            string id,
            global::tryAGI.OpenAI.BetaFileSearchToolCallStatus status,
            global::System.Collections.Generic.IList<string> queries,
            global::tryAGI.OpenAI.BetaAgentTag? agent,
            global::tryAGI.OpenAI.BetaFileSearchToolCallType type,
            global::System.Collections.Generic.IList<global::tryAGI.OpenAI.BetaFileSearchToolCallResultsVariant1Item>? results)
        {
            this.Agent = agent;
            this.Id = id ?? throw new global::System.ArgumentNullException(nameof(id));
            this.Type = type;
            this.Status = status;
            this.Queries = queries ?? throw new global::System.ArgumentNullException(nameof(queries));
            this.Results = results;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BetaFileSearchToolCall" /> class.
        /// </summary>
        public BetaFileSearchToolCall()
        {
        }

    }
}