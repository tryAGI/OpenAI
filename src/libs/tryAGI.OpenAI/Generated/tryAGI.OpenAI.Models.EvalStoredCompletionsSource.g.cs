
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A StoredCompletionsRunDataSource configuration describing a set of filters
    /// </summary>
    public sealed partial class EvalStoredCompletionsSource
    {
        /// <summary>
        /// The type of source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalStoredCompletionsSourceType Type { get; set; } = global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions;

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        public global::System.DateTimeOffset? CreatedAfter { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        public global::System.DateTimeOffset? CreatedBefore { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsSource" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
        /// <param name="metadata"></param>
        /// <param name="model"></param>
        /// <param name="createdAfter"></param>
        /// <param name="createdBefore"></param>
        /// <param name="limit"></param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalStoredCompletionsSource(
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? model,
            global::System.DateTimeOffset? createdAfter,
            global::System.DateTimeOffset? createdBefore,
            int? limit,
            global::tryAGI.OpenAI.EvalStoredCompletionsSourceType type = global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions)
        {
            this.Type = type;
            this.Metadata = metadata;
            this.Model = model;
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.Limit = limit;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsSource" /> class.
        /// </summary>
        public EvalStoredCompletionsSource()
        {
        }
    }
}