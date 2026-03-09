
#nullable enable

namespace tryAGI.OpenAI
{
    /// <summary>
    /// Deprecated in favor of LogsDataSourceConfig.
    /// </summary>
    [global::System.Obsolete("This model marked as deprecated.")]
    public sealed partial class CreateEvalStoredCompletionsDataSourceConfig
    {
        /// <summary>
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </summary>
        /// <default>global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions</default>
        [global::System.Text.Json.Serialization.JsonPropertyName("type")]
        [global::System.Text.Json.Serialization.JsonConverter(typeof(global::tryAGI.OpenAI.JsonConverters.CreateEvalStoredCompletionsDataSourceConfigTypeJsonConverter))]
        [global::System.Obsolete("This property marked as deprecated.")]
        public global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType Type { get; set; } = global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions;

        /// <summary>
        /// Metadata filters for the stored completions data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </summary>
        /// <example>
        /// {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </example>
        [global::System.Text.Json.Serialization.JsonPropertyName("metadata")]
        [global::System.Obsolete("This property marked as deprecated.")]
        public object? Metadata { get; set; }

        /// <summary>
        /// Additional properties that are not explicitly defined in the schema
        /// </summary>
        [global::System.Text.Json.Serialization.JsonExtensionData]
        public global::System.Collections.Generic.IDictionary<string, object> AdditionalProperties { get; set; } = new global::System.Collections.Generic.Dictionary<string, object>();

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        /// <param name="type">
        /// The type of data source. Always `stored_completions`.<br/>
        /// Default Value: stored_completions
        /// </param>
        /// <param name="metadata">
        /// Metadata filters for the stored completions data source.<br/>
        /// Example: {<br/>
        ///   "use_case": "customer_support_agent"<br/>
        /// }
        /// </param>
#if NET7_0_OR_GREATER
        [global::System.Diagnostics.CodeAnalysis.SetsRequiredMembers]
#endif
        public CreateEvalStoredCompletionsDataSourceConfig(
            object? metadata,
            global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType type = global::tryAGI.OpenAI.CreateEvalStoredCompletionsDataSourceConfigType.StoredCompletions)
        {
            this.Type = type;
            this.Metadata = metadata;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateEvalStoredCompletionsDataSourceConfig" /> class.
        /// </summary>
        public CreateEvalStoredCompletionsDataSourceConfig()
        {
        }
    }
}