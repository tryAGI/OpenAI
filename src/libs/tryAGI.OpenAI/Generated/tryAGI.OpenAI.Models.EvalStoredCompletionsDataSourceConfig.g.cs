
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Deprecated in favor of LogsDataSourceConfig.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class EvalStoredCompletionsDataSourceConfig
    {
        /// <summary>
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::System.Collections.Generic.Dictionary<string, string>? Metadata { get; set; }

        /// <summary>
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </summary>
        [global::System.Text.Json.Serialization.JsonPropertyName("schema")]
        [global::System.Text.Json.Serialization.JsonRequired]
        [global::System.Obsolete("This property marked as deprecated.")]
        public required object Schema { get; set; }

        /// <summary>
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType.StoredCompletions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.EvalStoredCompletionsDataSourceConfigTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType Type { get; set; } = global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType.StoredCompletions;

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="metadata">
        /// Set of 16 key-value pairs that can be attached to an object. This can be<br/>
        /// useful for storing additional information about the object in a structured<br/>
        /// format, and querying for objects via API or the dashboard. <br/>
        /// Keys are strings with a maximum length of 64 characters. Values are strings<br/>
        /// with a maximum length of 512 characters.
        /// </param>
        /// <param name="schema">
        /// The json schema for the run data source items.<br/>
        /// Learn how to build JSON schemas [here](https://json-schema.org/).
        /// </param>
        /// <param name="type">
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public EvalStoredCompletionsDataSourceConfig(
            object schema,
            global::System.Collections.Generic.Dictionary<string, string>? metadata,
            global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType type = global::tryAGI.OpenAI.EvalStoredCompletionsDataSourceConfigType.StoredCompletions)
        {
            this.Schema = schema ?? throw new global::System.ArgumentNullException(nameof(schema));
            this.Metadata = metadata;
            this.Type = type;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        public EvalStoredCompletionsDataSourceConfig()
        {
        }
    }
}