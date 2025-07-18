
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// A StoredCompletionsRunDataSource configuration describing a set of filters
    /// </summary>
    public sealed partial class EvalStoredCompletionsSource
    {
        /// <summary>
        /// An optional Unix timestamp to filter items created after this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_after")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedAfter { get; set; }

        /// <summary>
        /// An optional Unix timestamp to filter items created before this time.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("created_before")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.UnixTimestampJsonConverter))]
        public global::System.DateTimeOffset? CreatedBefore { get; set; }

        /// <summary>
        /// An optional maximum number of items to return.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("limit")]
        public int? Limit { get; set; }

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
        /// An optional model to filter by (e.g., 'gpt-4o').
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("model")]
        public string? Model { get; set; }

        /// <summary>
        /// The type of source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsSourceTypeJsonConverter))]
        public global::tryAGI.OpenAI.EvalStoredCompletionsSourceType Type { get; set; } = global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsSource" /> class.
        /// </summary>
        /// <param name="createdAfter">
        /// An optional Unix timestamp to filter items created after this time.
        /// </param>
        /// <param name="createdBefore">
        /// An optional Unix timestamp to filter items created before this time.
        /// </param>
        /// <param name="limit">
        /// An optional maximum number of items to return.
        /// </param>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="model">
        /// An optional model to filter by (e.g., 'gpt-4o').
        /// </param>
        /// <param name="type">
        /// The type of source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalStoredCompletionsSource(
            global::System.DateTimeOffset? createdAfter,
            global::System.DateTimeOffset? createdBefore,
            int? limit,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            string? model,
            global::tryAGI.OpenAI.EvalStoredCompletionsSourceType type = global::tryAGI.OpenAI.EvalStoredCompletionsSourceType.StoredCompletions)
        {
            this.CreatedAfter = createdAfter;
            this.CreatedBefore = createdBefore;
            this.Limit = limit;
            this.Metadata = metadata;
            this.Model = model;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsSource" /> class.
        /// </summary>
        public EvalStoredCompletionsSource()
        {
        }
    }
}